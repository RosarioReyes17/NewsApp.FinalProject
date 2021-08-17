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
        static HttpClient HttpClient = new HttpClient();

        ArtFormDto objArt = null;
        public CreateArticles()
        {
            InitializeComponent();

            HttpClient.BaseAddress = new Uri("https://localhost:44395/");
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

        private void InsertArticle()
        {
            if (objArt == null)
            {
                var articulos = new ArtFormDto
                {
                    Titulo = txtTitle.Text,
                    Descripcion = txtDescription.Text,
                    Contenido = txtContent.Text,
                    ArticuloUrl = txtArticleURL.Text,
                    ImagenUrl = txtImageURL.Text,
                    IdAutor = cmbAuthor.SelectedIndex,
                    IdCategoria = cmbCategory.SelectedIndex,
                    IdFuente = cmbSource.SelectedIndex,
                    IdPais = cmbCountry.SelectedIndex,
                    FechaPublicacion = DateTime.Now,


                };

                string json = JsonConvert.SerializeObject(articulos);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = HttpClient.PostAsync("/api/Articuloes", content).Result;

                if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Article Inserted");

                    clearFields();
                }
                else
                {
                    MessageBox.Show("Article error");
                }
            }
            else
            {
                objArt.Titulo = txtTitle.Text;
                objArt.Descripcion = txtDescription.Text;
                objArt.Contenido = txtContent.Text;
                objArt.ArticuloUrl = txtArticleURL.Text;
                objArt.ImagenUrl = txtImageURL.Text;
                objArt.IdAutor = cmbAuthor.SelectedIndex;
                objArt.IdCategoria = cmbCategory.SelectedIndex;
                objArt.IdFuente = cmbSource.SelectedIndex;
                objArt.IdPais = cmbCountry.SelectedIndex;
                objArt.FechaPublicacion = DateTime.Now;


                string json = JsonConvert.SerializeObject(objArt);

                StringContent content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = HttpClient.PostAsync("/api/Articuloes/" + objArt.IdArticulo.ToString(), content).Result;

                if (response.StatusCode == HttpStatusCode.Created || response.StatusCode == HttpStatusCode.OK)
                {
                    MessageBox.Show("Article Inserted");

                    clearFields();
                }
                else
                {
                    MessageBox.Show("Article error");
                }
            }
        }

        private void btnRegistrer_Click(object sender, EventArgs e)
        {
            InsertArticle();
        }
    }
}
