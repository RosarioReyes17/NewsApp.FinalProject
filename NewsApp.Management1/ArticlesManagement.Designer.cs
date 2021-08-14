
namespace NewsApp.Management1
{
    partial class ArticlesManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ArticlesManagement));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnRegistrerArticles = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCiitas = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnDocctores = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(41, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(291, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 65;
            this.pictureBox1.TabStop = false;
            // 
            // btnRegistrerArticles
            // 
            this.btnRegistrerArticles.BackColor = System.Drawing.Color.PaleGreen;
            this.btnRegistrerArticles.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistrerArticles.Location = new System.Drawing.Point(41, 343);
            this.btnRegistrerArticles.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrerArticles.Name = "btnRegistrerArticles";
            this.btnRegistrerArticles.Size = new System.Drawing.Size(291, 56);
            this.btnRegistrerArticles.TabIndex = 64;
            this.btnRegistrerArticles.Text = "ARTICLES REGISTRATION";
            this.btnRegistrerArticles.UseVisualStyleBackColor = false;
            this.btnRegistrerArticles.Click += new System.EventHandler(this.btnRegistrerArticles_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PaleGreen;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label6.Location = new System.Drawing.Point(4, 9);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(738, 55);
            this.label6.TabIndex = 62;
            this.label6.Text = "NEWS WORLD MANAGEMENT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCiitas
            // 
            this.btnCiitas.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCiitas.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCiitas.Location = new System.Drawing.Point(544, 343);
            this.btnCiitas.Margin = new System.Windows.Forms.Padding(2);
            this.btnCiitas.Name = "btnCiitas";
            this.btnCiitas.Size = new System.Drawing.Size(149, 56);
            this.btnCiitas.TabIndex = 63;
            this.btnCiitas.Text = "REGISTRO DE \r\nCITAS";
            this.btnCiitas.UseVisualStyleBackColor = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(544, 179);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(149, 148);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 67;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(370, 177);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 148);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 66;
            this.pictureBox2.TabStop = false;
            // 
            // btnDocctores
            // 
            this.btnDocctores.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDocctores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDocctores.Location = new System.Drawing.Point(370, 343);
            this.btnDocctores.Name = "btnDocctores";
            this.btnDocctores.Size = new System.Drawing.Size(149, 56);
            this.btnDocctores.TabIndex = 69;
            this.btnDocctores.Text = "REGISTRO DE DOCTORES";
            this.btnDocctores.UseVisualStyleBackColor = false;
            // 
            // ArticlesManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSlateGray;
            this.ClientSize = new System.Drawing.Size(748, 414);
            this.Controls.Add(this.btnDocctores);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCiitas);
            this.Controls.Add(this.btnRegistrerArticles);
            this.Controls.Add(this.label6);
            this.Name = "ArticlesManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArticlesManagement";
            this.Load += new System.EventHandler(this.ArticlesManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnRegistrerArticles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCiitas;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnDocctores;
    }
}