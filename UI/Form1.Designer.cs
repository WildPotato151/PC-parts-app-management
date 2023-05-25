namespace UI
{
    partial class Form1
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
            this.lblModel = new System.Windows.Forms.Label();
            this.txtIModel = new System.Windows.Forms.TextBox();
            this.lblMesaj = new System.Windows.Forms.Label();
            this.btnAfiseazaInchiriere = new System.Windows.Forms.Button();
            this.txtBrand = new System.Windows.Forms.TextBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.btnAdaugaInchiriere = new System.Windows.Forms.Button();
            this.lblBrand = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblPret = new System.Windows.Forms.Label();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(70, 82);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 69;
            this.lblModel.Text = "Model";
            // 
            // txtIModel
            // 
            this.txtIModel.Location = new System.Drawing.Point(112, 79);
            this.txtIModel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIModel.Name = "txtIModel";
            this.txtIModel.Size = new System.Drawing.Size(277, 20);
            this.txtIModel.TabIndex = 68;
            // 
            // lblMesaj
            // 
            this.lblMesaj.AutoSize = true;
            this.lblMesaj.Location = new System.Drawing.Point(109, 190);
            this.lblMesaj.Name = "lblMesaj";
            this.lblMesaj.Size = new System.Drawing.Size(34, 13);
            this.lblMesaj.TabIndex = 67;
            this.lblMesaj.Text = "mesaj";
            // 
            // btnAfiseazaInchiriere
            // 
            this.btnAfiseazaInchiriere.Location = new System.Drawing.Point(265, 149);
            this.btnAfiseazaInchiriere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAfiseazaInchiriere.Name = "btnAfiseazaInchiriere";
            this.btnAfiseazaInchiriere.Size = new System.Drawing.Size(124, 28);
            this.btnAfiseazaInchiriere.TabIndex = 66;
            this.btnAfiseazaInchiriere.Text = "Afiseaza";
            this.btnAfiseazaInchiriere.UseVisualStyleBackColor = true;
            this.btnAfiseazaInchiriere.Click += new System.EventHandler(this.afiseazaButton_Click);
            // 
            // txtBrand
            // 
            this.txtBrand.Location = new System.Drawing.Point(112, 45);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.Size = new System.Drawing.Size(277, 20);
            this.txtBrand.TabIndex = 65;
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(112, 11);
            this.txtNume.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(277, 20);
            this.txtNume.TabIndex = 64;
            // 
            // btnAdaugaInchiriere
            // 
            this.btnAdaugaInchiriere.Location = new System.Drawing.Point(112, 149);
            this.btnAdaugaInchiriere.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdaugaInchiriere.Name = "btnAdaugaInchiriere";
            this.btnAdaugaInchiriere.Size = new System.Drawing.Size(124, 28);
            this.btnAdaugaInchiriere.TabIndex = 63;
            this.btnAdaugaInchiriere.Text = "Adauga";
            this.btnAdaugaInchiriere.UseVisualStyleBackColor = true;
            this.btnAdaugaInchiriere.Click += new System.EventHandler(this.adaugaButton_Click);
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Location = new System.Drawing.Point(70, 48);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(35, 13);
            this.lblBrand.TabIndex = 62;
            this.lblBrand.Text = "Brand";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(71, 14);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 61;
            this.lblNume.Text = "Nume";
            // 
            // lblPret
            // 
            this.lblPret.AutoSize = true;
            this.lblPret.Location = new System.Drawing.Point(79, 115);
            this.lblPret.Name = "lblPret";
            this.lblPret.Size = new System.Drawing.Size(26, 13);
            this.lblPret.TabIndex = 71;
            this.lblPret.Text = "Pret";
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(112, 112);
            this.txtPret.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(277, 20);
            this.txtPret.TabIndex = 70;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblPret);
            this.Controls.Add(this.txtPret);
            this.Controls.Add(this.lblModel);
            this.Controls.Add(this.txtIModel);
            this.Controls.Add(this.lblMesaj);
            this.Controls.Add(this.btnAfiseazaInchiriere);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnAdaugaInchiriere);
            this.Controls.Add(this.lblBrand);
            this.Controls.Add(this.lblNume);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.TextBox txtIModel;
        private System.Windows.Forms.Label lblMesaj;
        private System.Windows.Forms.Button btnAfiseazaInchiriere;
        private System.Windows.Forms.TextBox txtBrand;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Button btnAdaugaInchiriere;
        private System.Windows.Forms.Label lblBrand;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblPret;
        private System.Windows.Forms.TextBox txtPret;
    }
}

