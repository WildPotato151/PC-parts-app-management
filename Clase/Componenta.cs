using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Componenta
    {
        private string nume;
        private string brand;
        private string model;
        private float pret;


        public Componenta()
        {
            nume = string.Empty;
            brand = string.Empty;
            model = string.Empty;
            pret = 0.0f;
        }
        
        public Componenta(string nume, string brand, string model, float pret)
        {
            this.nume = nume;
            this.brand = brand;
            this.model = model;
            this.pret = pret;

        }

        public string GetNume()
        {
            return nume;
        }

        public string GetBrand()
        {
            return brand;
        }

        public string GetModel()
        {
            return model;
        }

        public float GetPret() 
        {
            return pret;
        }

        public string showInfo()
        {
            return $"Nume: {nume} | Brand: {brand} | Model: {model} | Pret:{pret} lei";
        }
    
        public void SetNume(string nume)
        {
            this.nume = nume;
        }

        public void SetBrand(string brand) 
        {
            this.brand = brand; 
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public void SetPret(float pret)
        {
            this.pret = pret;
        }
        public class Scriere_fisier
        {
            public void scrie_in_fisier(Componenta componenta, string filePath)
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine("Nume: " + componenta.nume);
                    writer.WriteLine("Brand: " + componenta.brand);
                    writer.WriteLine("Model: " + componenta.model);
                    writer.WriteLine("Pret: " + componenta.pret + " lei");
                    writer.WriteLine("---------------------------------");

                    writer.Close();
                }
            }
        }

    }
}
