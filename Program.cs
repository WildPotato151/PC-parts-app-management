using Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Configuration;

using CompomenteDataManagement;

namespace PC_parts_app_management
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            
            bool exit = false;
            //string filePath = "text.txt";
            List<Componenta> componentaList = new List<Componenta>();
            Componenta componenta = new Componenta();

            
           
            string locatieFisierSolutie = Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.Parent.FullName;
            
            string caleCompletaFisierComponente = locatieFisierSolutie + "\\" + "componenta.txt";


            AdministrareComponente adminComponente = new AdministrareComponente(caleCompletaFisierComponente);
            

            while (!exit)
            {
                Console.WriteLine("1. Seteaza o componenta ");
                Console.WriteLine("2. Afiseaza ultima componenta ");
                Console.WriteLine("3. Salveaza componenta in fisier");
                Console.WriteLine("4. Afiseaza toate componentele ");
                Console.WriteLine("5. Cauta componenta dupa nume, model sau brand");
                Console.WriteLine("6. Citire componente din fisier");
                Console.WriteLine("7. Iesire program");
                Console.Write("Introdu optiune: ");

                string optiune = Console.ReadLine();
                Console.WriteLine();

                switch (optiune)
                {
                    case "1":
                       // Componenta componenta = new Componenta();
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
                            adminComponente.AddComponenta(componenta);
                            Console.WriteLine("Componente adaugate in fisier");
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
                        /*case "6":
                        
                        componentaList = Componenta.GetComponente();
                        Console.WriteLine("Componentele au fost citite.");
                        foreach (Componenta c in componentaList)
                        {
                            Console.WriteLine(c.showInfo());
                        }
                        break; */
                    case "7":
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
