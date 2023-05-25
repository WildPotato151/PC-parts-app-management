using System;
using Clase;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompomenteDataManagement;
using System.IO;

namespace UI
{
    
    public partial class Form1 : Form
    {
        AdministrareComponente adminComponente;

        private Label lblHeaderNume;
        private Label lblHeaderBrand;
        private Label lblHeaderModel;
        private Label lblHeaderPret;

        private Label[] lblsNume;
        private Label[] lblsBrand;
        private Label[] lblsModel;
        private Label[] lblsPret;

        private const int LATIME_CONTROL = 100;
        private const int DIMENSIUNE_PAS_Y = 30;
        private const int DIMENSIUNE_PAS_X = 120;
        private const int OFFSET_X = 600;
        public Form1()
        {
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;

            string caleCompletaFisierComponente = locatieFisierSolutie + "\\" + "componenta.txt";

            adminComponente = new AdministrareComponente(caleCompletaFisierComponente);

            InitializeComponent();

           
            this.Size = new Size(500, 600);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.Font = new Font("Arial", 9, FontStyle.Bold);
            this.ForeColor = Color.Blue;
            this.Text = "Formular Componente";

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblMesaj.Text = "";
            lblMesaj.ForeColor = Color.Red;
            AfiseazaComponente();
        }

        private void AfiseazaComponente()
        {
            lblHeaderNume = new Label();
            lblHeaderNume.Width = LATIME_CONTROL;
            lblHeaderNume.Text = "Nume";
            lblHeaderNume.Left = OFFSET_X + 0;
            lblHeaderNume.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderNume);

            lblHeaderBrand = new Label();
            lblHeaderBrand.Width = LATIME_CONTROL;
            lblHeaderBrand.Text = "Brand";
            lblHeaderBrand.Left = OFFSET_X + DIMENSIUNE_PAS_X;
            lblHeaderBrand.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderBrand);

            lblHeaderModel = new Label();
            lblHeaderModel.Width = LATIME_CONTROL;
            lblHeaderModel.Text = "Model";
            lblHeaderModel.Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
            lblHeaderModel.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderModel);

            lblHeaderPret = new Label();
            lblHeaderPret.Width = LATIME_CONTROL;
            lblHeaderPret.Text = "Pret";
            lblHeaderPret.Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
            lblHeaderPret.ForeColor = Color.DarkBlue;
            this.Controls.Add(lblHeaderPret);

            int nrComponente = 0;
            Componenta[] componente = adminComponente.GetComponente(out nrComponente);

            lblsNume = new Label[nrComponente];
            lblsBrand = new Label[nrComponente];
            lblsModel = new Label[nrComponente];
            lblsPret = new Label[nrComponente];

            int i = 0;
            foreach (Componenta componenta in componente)
            {
                if (i >= nrComponente)
                    break;

                
                lblsNume[i] = new Label();
                lblsNume[i].Width = LATIME_CONTROL;
                lblsNume[i].Text = componenta.nume;
                lblsNume[i].Left = OFFSET_X + 0;
                lblsNume[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsNume[i]);

                
                lblsBrand[i] = new Label();
                lblsBrand[i].Width = LATIME_CONTROL;
                lblsBrand[i].Text = componenta.brand;
                lblsBrand[i].Left = OFFSET_X + DIMENSIUNE_PAS_X;
                lblsBrand[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsBrand[i]);

                
                lblsModel[i] = new Label();
                lblsModel[i].Width = LATIME_CONTROL;
                lblsModel[i].Text = componenta.model;
                lblsModel[i].Left = OFFSET_X + 2 * DIMENSIUNE_PAS_X;
                lblsModel[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsModel[i]);

                
                lblsPret[i] = new Label();
                lblsPret[i].Width = LATIME_CONTROL;
                lblsPret[i].Text = componenta.pret.ToString()+" ron";
                lblsPret[i].Left = OFFSET_X + 3 * DIMENSIUNE_PAS_X;
                lblsPret[i].Top = (i + 1) * DIMENSIUNE_PAS_Y;
                this.Controls.Add(lblsPret[i]);

                i++;
            }
        }


        private void adaugaButton_Click(object sender, EventArgs e)
        {

            
            if (!ValidareDate())
            {
                lblMesaj.Text = "Eroare!";
                lblMesaj.ForeColor= Color.Red;

                return;
            }

            lblMesaj.Text = "";

            string nume = txtNume.Text.Trim();
            string brand = txtBrand.Text.Trim();
            string model = txtIModel.Text.Trim();
            float pret = float.Parse(txtPret.Text.Trim());

            Componenta componenta = new Componenta(nume, brand, model, pret);

            adminComponente.AddComponenta(componenta);
            lblMesaj.ForeColor = Color.BlueViolet;
            lblMesaj.Text = "Componenta a fost adaugata";

            
            ClearTextBoxes();
        }

        private void afiseazaButton_Click(object sender, EventArgs e)
        {
            AfiseazaComponente();
            this.Width = 1200;
        }

        private bool ValidareDate()
        {
            bool isValid = true;

            if (txtNume.Text.Trim().Length == 0 || txtNume.Text.Trim().Length > 15)
            {
                lblNume.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblNume.ForeColor = Color.DarkBlue;
            }

            if (txtBrand.Text.Trim().Length == 0 || txtBrand.Text.Trim().Length > 15)
            {
                lblBrand.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblBrand.ForeColor = Color.DarkBlue;
            }

            if (txtIModel.Text.Trim().Length == 0 || txtIModel.Text.Trim().Length > 15)
            {
                lblModel.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblModel.ForeColor = Color.DarkBlue;
            }

            float pret;
            if (!float.TryParse(txtPret.Text.Trim(), out pret))
            {
                lblPret.ForeColor = Color.Red;
                isValid = false;
            }
            else
            {
                lblPret.ForeColor = Color.DarkBlue;
            }

            return isValid;
        }

        private void ClearTextBoxes()
        {
            txtNume.Text = "";
            txtBrand.Text = "";
            txtIModel.Text = "";
            txtPret.Text = "";
        }
    }

   
}
   
