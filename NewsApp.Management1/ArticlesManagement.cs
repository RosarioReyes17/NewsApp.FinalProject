using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewsApp.Management1
{
    public partial class ArticlesManagement : Form
    {
        public ArticlesManagement()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void ArticlesManagement_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrerArticles_Click(object sender, EventArgs e)
        {
            CreateArticles createA = new CreateArticles();
            createA.ShowDialog();
            this.Close();
        }
    }
}
