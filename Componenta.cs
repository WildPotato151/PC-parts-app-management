using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PC_parts_app_management
{
    public class Componenta
    {
        string nume;
        string brand;
        string model;
        float pret;

        public Componenta(string _nume, string _brand, string _model, float _pret)
        {
         nume = _nume;
         brand = _brand;
         model = _model;
         pret = _pret;
        
        }
        

    }
}
