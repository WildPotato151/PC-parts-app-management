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
            //Componenta componenta = null;
            bool exit = false;
            string filePath = "text.txt";
            List<Componenta> componentaList = new List<Componenta>();

            while (!exit)
            {
                Console.WriteLine("1. Seteaza o componenta ");
                Console.WriteLine("2. Afiseaza ultima componenta ");
                Console.WriteLine("3. Salveaza componenta in fisier");
                Console.WriteLine("4. Afiseaza toate componentele ");
                Console.WriteLine("5. Cauta componenta dupa nume, model sau brand");
                Console.WriteLine("6. Iesire program");
                Console.Write("Introdu optiune: ");

                string optiune = Console.ReadLine();
                Console.WriteLine();

                switch (optiune)
                {
                    case "1":
                        Componenta componenta = new Componenta();
                        componenta.GetInput();
                        componentaList.Add(componenta);
                        break;
                    case "2":
                        if (componentaList.Count > 0) 
                        {
                            Console.WriteLine(componentaList.Last().showInfo());
                        }
                        else
                        {
                            Console.WriteLine("Nu exista o componenta setata.");
                        }
                        break;
                    case "3":
                        if (componentaList.Count > 0)
                        {
                            Componenta.Scriere_fisier fisier = new Componenta.Scriere_fisier();
                            fisier.scrie_in_fisier(componentaList.Last(), filePath);
                        }
                        else
                        {
                            Console.WriteLine("Nu exista o componenta setata.");
                        }
                        break;
                    case "4":
                        if (componentaList.Count > 0)
                        {
                            Console.WriteLine("Afiseaza toate componentele:");
                            foreach (Componenta c in componentaList.OrderBy(x => x.GetBrand()))
                            {
                                Console.WriteLine(c.showInfo());
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nu exista nicio componenta setata.");
                        }
                        break;
                    case "5":
                        Console.WriteLine("Introduceti termenul de cautare:");
                        bool termenGasit = false;
                        string termenCautat = Console.ReadLine().ToLower();
                        Console.WriteLine("Rezultatele cautarii:");
                        foreach (Componenta c in componentaList)
                        {
                            if (c.GetNume().ToLower().Contains(termenCautat) || 
                                c.GetBrand().ToLower().Contains(termenCautat) || 
                                c.GetModel().ToLower().Contains(termenCautat))
                            {
                                Console.WriteLine(c.showInfo());
                                termenGasit = true;
                            }
                        }
                        if (!termenGasit)
                        {
                            Console.WriteLine($"Nu s-a gasit nicio componenta care sa contina cuvantul '{termenCautat}'.");
                        }
                        break;
                    case "6":
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
