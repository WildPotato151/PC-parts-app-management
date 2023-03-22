using Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace PC_parts_app_management
{
    public class Program
    {
        static void Main(string[] args)
        {
            Componenta c1 = new Componenta("CPU", "AMD", "3200g", 350f);
            Console.WriteLine($"Nume: {c1.GetNume()} | Brand: {c1.GetBrand()} | Model: {c1.GetModel()} | Pret: {c1.GetPret()} lei");

            Componenta c2 = new Componenta("GPU", "NVIDIA", "RTX 4080", 4000f);
            Console.WriteLine($"Nume: {c2.GetNume()} | Brand: {c2.GetBrand()} | Model: {c2.GetModel()} | Pret: {c2.GetPret()} lei");

            Componenta c3 = new Componenta("ssd", "kingston", "a400", 150f);
            string showC3 = c3.showInfo();
            Console.WriteLine(showC3);
            
            Console.ReadKey();

        }
    }
    
}
