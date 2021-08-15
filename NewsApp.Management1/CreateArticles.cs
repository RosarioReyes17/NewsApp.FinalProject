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
    public partial class CreateArticles : Form
    {
        static HttpClient httpClient = new HttpClient();

        public CreateArticles()
        {
            InitializeComponent();
        }

        private void btnConsult_Click(object sender, EventArgs e)
        {
            ConsultArticle consultA = new ConsultArticle();
            consultA.ShowDialog();
            this.Close();
        }

        private void CreateArticles_Load(object sender, EventArgs e)
        {
            MetodAuthors();
            MetodCategory();
            MetodSources();
            MetodCountry();

        }

        private async Task<string> GetHttp()
        {
            WebRequest request = WebRequest.Create("https://localhost:44395/api/Articuloes");
            WebResponse response = request.GetResponse();
            StreamReader a = new StreamReader(response.GetResponseStream());
            return await a.ReadToEndAsync();
        }

        private async Task<string> GetHttpAuthor()
        {
            WebRequest request = WebRequest.Create("https://localhost:44395/api/Autores");
            WebResponse response = request.GetResponse();
            StreamReader a = new StreamReader(response.GetResponseStream());
            return await a.ReadToEndAsync();
        }

        private async Task<string> GetHttpCategory()
        {
            WebRequest request = WebRequest.Create("https://localhost:44395/api/Categorias");
            WebResponse response = request.GetResponse();
            StreamReader a = new StreamReader(response.GetResponseStream());
            return await a.ReadToEndAsync();
        }

        private async Task<string> GetHttpSource()
        {
            WebRequest request = WebRequest.Create("https://localhost:44395/api/Fuentes");
            WebResponse response = request.GetResponse();
            StreamReader a = new StreamReader(response.GetResponseStream());
            return await a.ReadToEndAsync();
        }

        private async Task<string> GetHttpCountry()
        {
            WebRequest request = WebRequest.Create("https://localhost:44395/api/Paises");
            WebResponse response = request.GetResponse();
            StreamReader a = new StreamReader(response.GetResponseStream());
            return await a.ReadToEndAsync();
        }

        private async void MetodSources()
        {
            string meto = await GetHttpSource();
            List<FuenteDTO> List
                = JsonConvert.DeserializeObject<List<FuenteDTO>>(meto);

            var objSource = new FuenteDTO { IdFuente = 0, NombreFuente = "SELECT SOURCE" };
            List.Insert(0, objSource);

            cmbSource.DataSource = List;
            cmbSource.DisplayMember = "NombreFuente";
            cmbSource.ValueMember = "IdFuente";

        }

        private async void MetodAuthors()
        {
            string meto = await GetHttpAuthor();
            List<AuthorDTO> List
                = JsonConvert.DeserializeObject<List<AuthorDTO>>(meto);

            var objAuth = new AuthorDTO { IdAutor = 0, NombreCompleto = "SELECT AUTHOR" };
            List.Insert(0, objAuth);

            cmbAuthor.DataSource = List;
            cmbAuthor.DisplayMember = "NombreCompleto";
            cmbAuthor.ValueMember = "IdAutor";

        }

        private async void MetodCategory()
        {
            string meto = await GetHttpCategory();
            List<CategDTO> List
                = JsonConvert.DeserializeObject<List<CategDTO>>(meto);

            var objCateg = new CategDTO { IdCategoria = 0, NombreCategoria = "SELECT CATEGORY" };
            List.Insert(0, objCateg);

            cmbCategory.DataSource = List;
            cmbCategory.DisplayMember = "NombreCategoria";
            cmbCategory.ValueMember = "IdCategoria";

        }

        private async void MetodCountry()
        {
            string meto = await GetHttpCountry();
            List<PaisDTO> List
                = JsonConvert.DeserializeObject<List<PaisDTO>>(meto);

            var objPais = new PaisDTO { IdPais = 0, NombrePais = "SELECT COUNTRY" };
            List.Insert(0, objPais);

            cmbCountry.DataSource = List;
            cmbCountry.DisplayMember = "NombrePais";
            cmbCountry.ValueMember = "IdPais";

        }

        void clearFields()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox || c is MaskedTextBox)
                {
                    c.Text = "";
                }
            }
            cmbAuthor.SelectedIndex = 0;
            cmbCategory.SelectedIndex = 0;
            cmbCountry.SelectedIndex = 0;
            cmbSource.SelectedIndex = 0;
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            clearFields();
        }
    }
}
