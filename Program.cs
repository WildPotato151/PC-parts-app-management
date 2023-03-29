using Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;






namespace PC_parts_app_management
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Componenta c1 = new Componenta("CPU", "AMD", "3200g", 350f);
            Console.WriteLine($"Nume: {c1.GetNume()} | Brand: {c1.GetBrand()} | Model: {c1.GetModel()} | Pret: {c1.GetPret()} lei");
            string filePath = "text.txt";
            Componenta.Scriere_fisier fisier = new Componenta.Scriere_fisier();
            fisier.scrie_in_fisier(c1, filePath);

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

            Componenta c5 = new Componenta();
            c5.GetInput();
            Console.WriteLine(c5.showInfo());
            */
            Componenta componenta = new Componenta();
            bool exit = false;
            string filePath = "text.txt";

            while (!exit)
            {
                Console.WriteLine("1. Seteaza o componenta ");
                Console.WriteLine("2. Afiseaza o componenta ");
                Console.WriteLine("3. Salveaza componenta in fisier");
                Console.WriteLine("4. Iesire program");
                Console.Write("Introdu optiune: ");

                string optiune = Console.ReadLine();
                Console.WriteLine();

                switch (optiune)
                {
                    case "1":
                        componenta.GetInput();
                        break;
                    case "2":
                        Console.WriteLine(componenta.showInfo());
                        break;
                    case "3":
                        Componenta.Scriere_fisier fisier = new Componenta.Scriere_fisier();
                        fisier.scrie_in_fisier(componenta, filePath);
                        break;
                    case "4":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Optiune invalida.");
                        break;
                }

                Console.WriteLine();
            }




            Console.ReadKey();

        }
    }
    
}
