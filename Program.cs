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

            var c4 = new Componenta();
            Console.WriteLine("Introdu nume: ");
            string f1 = Console.ReadLine();
            c4.SetNume(f1);

            Console.WriteLine("Introdu brand: ");
            string f2 = Console.ReadLine();
            c4.SetBrand(f2);

            Console.WriteLine("Introdu model: ");
            string f3 = Console.ReadLine();
            c4.SetModel(f3);

            Console.WriteLine("Introdu pret: ");
            float f4 = Convert.ToInt32(Console.ReadLine());
            c4.SetPret(f4);


            string showC4 = c4.showInfo();
            Console.WriteLine(showC4);


            


            Console.ReadKey();

        }
    }
    
}
