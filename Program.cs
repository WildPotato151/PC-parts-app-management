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
            Componenta c1 = new Componenta("CPU", "tes", "dqdqdqd", 24.5f);
            Console.WriteLine(c1.GetNume());

            Console.WriteLine("yes");
            

          
            
            Console.ReadKey();

        }
    }
    
}
