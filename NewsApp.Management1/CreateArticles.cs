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
    public partial class CreateArticles : Form
    {
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
    }
}
