using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsApp.Management1
{
    public partial class ConsultArticle : Form
    {
        string url = "https://localhost:44395/api/Articuloes";

        static HttpClient httpClient = new HttpClient();
        List<ArtFormDto> articles;

        public ConsultArticle()
        {
            InitializeComponent();
        }

        private void ConsultArticle_Load(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private async Task<List<ArtFormDto>> GetArticles()
        {
            string response = await GetHttp();

            articles = JsonConvert.DeserializeObject<List<ArtFormDto>>(response);

            return articles;
        }

        private async void LoadGridData()
        {
            await GetArticles();

            var list = (from a in articles
                        where a.Titulo.ToLower().Contains(txtSearch.Text.ToLower())
                        || a.NombreCompleto.ToLower().Contains(txtSearch.Text.ToLower())
                        || a.Contenido.ToLower().Contains(txtSearch.Text.ToLower())
                        select new
                        {
                            IdArticulo = a.IdArticulo,
                            NombreCompleto = a.NombreCompleto,
                            Title = a.Titulo,
                            Description = a.Descripcion,
                            Content = a.Contenido,
                            ArticuloURL = a.ArticuloUrl,
                            ImageURL = a.ImagenUrl,
                            Date = a.FechaPublicacion,
                            Category = a.NombreCategoria,
                            Country = a.NombrePais,
                            Source = a.NombreFuente,
                        }).ToList();

            dtgArticlesConsult.DataSource = list;
            dtgArticlesConsult.Columns[0].Visible = false;
        }


        private async Task<string> GetHttp()
        {
            WebRequest request = WebRequest.Create(url);
            WebResponse response = request.GetResponse();

            StreamReader stream = new StreamReader(response.GetResponseStream());

            return await stream.ReadToEndAsync();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadGridData();
        }

        private void ARTICLES(object sender, EventArgs e)
        {

        }



        private void dtgArticlesConsult_DataSourceChanged(object sender, EventArgs e)
        {
            labelRegistros.Text = "REGISTROS: " + dtgArticlesConsult.RowCount;
        }
    }
}
