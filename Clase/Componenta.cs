using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase
{
    public class Componenta
    {
        private string nume;
        public string brand;
        public string model;
        public float pret;


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

    }
}
