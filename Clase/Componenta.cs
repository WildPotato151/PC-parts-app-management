using System;
using Clase.Enum;
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
        private const char SEPARATOR_PRINCIPAL_FISIER = ';';
        /*private string nume;
        private string brand;
        private string model;
        private float pret;*/
        public string nume { get; set; }
        public string brand { get; set; }
        public string model { get; set; }
        public float pret { get; set; }

        private const int NUME = 0;
        private const int BRAND = 1;
        private const int MODEL = 2;
        private const int PRET = 3;

        public TipComponenta tipComponenta { get; set; }

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

        public void GetInput()
        {
            Console.WriteLine("Introduceti numele componentei:");
            SetNume(Console.ReadLine());

            Console.WriteLine("Introduceti brand-ul componentei:");
            SetBrand(Console.ReadLine());

            Console.WriteLine("Introduceti modelul componentei:");
            SetModel(Console.ReadLine());

            Console.WriteLine("Introduceti pretul componentei:");
            float pret;
            while (!float.TryParse(Console.ReadLine(), out pret))
            {
                Console.WriteLine("Introduceti un pret valid:");
            }
            SetPret(pret);
        }

        public Componenta(string linieFisier)
        {
            var dateFisier = linieFisier.Split(SEPARATOR_PRINCIPAL_FISIER);

            nume = dateFisier[NUME];
            brand = dateFisier[BRAND];
            model = dateFisier[MODEL];
            pret = float.Parse(dateFisier[PRET]);

            
        }
        public string ConversieLaSir_PentruFisier()
        {
            string obiectInchirierePentruFisier = string.Format("{1}{0}{2}{0}{3}{0}{4}{0}",
                SEPARATOR_PRINCIPAL_FISIER,
                (nume ?? " NECUNOSCUT "),
                (brand ?? " NECUNOSCUT "),
                (model.ToString() ?? " NECUNOSCUT "),
                (pret.ToString()));

            return obiectInchirierePentruFisier;
        }



        /* public static List<Componenta> Citire_fisier(string filePath = "componente.txt")
         {
             List<Componenta> components = new List<Componenta>();

             try
             {
                 using (StreamReader reader = new StreamReader(filePath))
                 {
                     string line;
                     while ((line = reader.ReadLine()) != null)
                     {
                         string[] values = line.Split('|');
                         if (values.Length == 4)
                         {
                             string nume = values[0].Trim();
                             string brand = values[1].Trim();
                             string model = values[2].Trim();
                             float pret = float.Parse(values[3].Trim());
                             Componenta componenta = new Componenta(nume, brand, model, pret);
                             components.Add(componenta);
                         }
                     }
                 }
             }
             catch (Exception ex)
             {
                 Console.WriteLine($"Eroare la citirea din fișier: {ex.Message}");
             }

             return components;
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
         }*/

    }
}
