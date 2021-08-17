
namespace NewsApp.Management1
{
    partial class ConsultArticle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label6 = new System.Windows.Forms.Label();
            this.dtgArticlesConsult = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.labelRegistros = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticlesConsult)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(160, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(490, 57);
            this.label6.TabIndex = 99;
            this.label6.Text = "SEARCH ARTICLES";
            // 
            // dtgArticlesConsult
            // 
            this.dtgArticlesConsult.BackgroundColor = System.Drawing.Color.LightCyan;
            this.dtgArticlesConsult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgArticlesConsult.Location = new System.Drawing.Point(12, 133);
            this.dtgArticlesConsult.Name = "dtgArticlesConsult";
            this.dtgArticlesConsult.RowTemplate.Height = 25;
            this.dtgArticlesConsult.Size = new System.Drawing.Size(776, 269);
            this.dtgArticlesConsult.TabIndex = 100;
            this.dtgArticlesConsult.DataSourceChanged += new System.EventHandler(this.dtgArticlesConsult_DataSourceChanged);
            this.dtgArticlesConsult.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgArticlesConsult_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtSearch.Location = new System.Drawing.Point(160, 86);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(490, 29);
            this.txtSearch.TabIndex = 101;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // labelRegistros
            // 
            this.labelRegistros.AutoSize = true;
            this.labelRegistros.BackColor = System.Drawing.Color.LightGreen;
            this.labelRegistros.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelRegistros.Location = new System.Drawing.Point(627, 411);
            this.labelRegistros.Name = "labelRegistros";
            this.labelRegistros.Size = new System.Drawing.Size(141, 30);
            this.labelRegistros.TabIndex = 103;
            this.labelRegistros.Text = "REGISTROS: 0";
            this.labelRegistros.TextChanged += new System.EventHandler(this.ARTICLES);
            // 
            // ConsultArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelRegistros);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtgArticlesConsult);
            this.Controls.Add(this.label6);
            this.Name = "ConsultArticle";
            this.Text = "ConsultArticle";
            this.Load += new System.EventHandler(this.ConsultArticle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgArticlesConsult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgArticlesConsult;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label labelRegistros;
    }
}