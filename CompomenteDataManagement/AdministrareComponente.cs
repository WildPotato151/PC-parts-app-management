using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase;

namespace CompomenteDataManagement
{
    public class AdministrareComponente
    {
        private const int NR_MAX_COMPONENTE = 100;
        private string numeFisier;

        public AdministrareComponente(string numeFisier)
        {
            this.numeFisier = numeFisier;
            Stream streamFisierText = File.Open(numeFisier, FileMode.OpenOrCreate);
            streamFisierText.Close();
        }

        public void AddComponenta(Componenta componenta)
        {
            using (StreamWriter streamWriterFisierText = new StreamWriter(numeFisier, true))
            {
                streamWriterFisierText.WriteLine(componenta.ConversieLaSir_PentruFisier());
            }
        }

        public Componenta[] GetComponente(out int nrComponente)
        {
            Componenta[] componente = new Componenta[NR_MAX_COMPONENTE];

            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                nrComponente = 0;

                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    componente[nrComponente++] = new Componenta(linieFisier);
                }
            }

            return componente;
        }

        public Componenta GetComponenta(string nume, string brand, string model)
        {
            
            using (StreamReader streamReader = new StreamReader(numeFisier))
            {
                string linieFisier;
                
                
                while ((linieFisier = streamReader.ReadLine()) != null)
                {
                    Componenta componenta = new Componenta(linieFisier);
                    if (componenta.nume == nume && componenta.brand == brand && componenta.model == model)
                    {
                        return componenta;
                    }
                }
            }

            return new Componenta();
        }


    }
}
