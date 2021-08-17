using Docker.DotNet.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsApp.Management1
{
    public partial class FormLoggin : Form
    {
        public FormLoggin()
        {
            InitializeComponent();
        }

        private void FormLoggin_Load(object sender, EventArgs e)
        {
            
        }

        public class NewsAppClient
        {
            static HttpClient httpClient = new HttpClient();

            public NewsAppClient()
            {
                httpClient.BaseAddress = new Uri("https://localhost:44395/");
            }

            public AuthResponse Authenticate(string username, string password)
            {
                var FormData = new MultipartFormDataContent("Upload----" + DateTime.Now.ToString(CultureInfo.InvariantCulture));
                FormData.Add(new StringContent(username), "NombreUsuario");
                FormData.Add(new StringContent(password), "Clave");

                var response = httpClient.PostAsync("/api/Loggin/Authenticate", FormData).Result;
                var responseText = response.Content.ReadAsStringAsync().Result;

                if (response.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var responseObject = JsonConvert.DeserializeObject<AuthResponse>(responseText);

                    //httpClient.DefaultRequestHeaders.Authorization = new("Bearer", responseObject.IdentityToken);

                    MessageBox.Show("Signed");

                    ArticlesManagement am = new ArticlesManagement();
                    am.ShowDialog();
                    

                    return responseObject;
                    
                }
                else if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                {
                    MessageBox.Show("Login invalid");
                    throw new UnauthorizedAccessException("Login Invalid");
                }
                else
                {
                    throw new ApplicationException("Internal server error");
                }
            }



        }



        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSing_Click(object sender, EventArgs e)
        {
            NewsAppClient newsc = new NewsAppClient();
            

            var auth = newsc.Authenticate(txtUser.Text, txtPassword.Text);


        }

        private void FormLoggin_Load_1(object sender, EventArgs e)
        {

        }
    }
}
