using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CountriesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string willContinue = "y";
            CountryController cc = new CountryController();

            do
            {
                cc.WelcomeAction();
                Console.WriteLine("\n" +
                    "Would you like to select another country?\n" +
                    "");
                willContinue = Console.ReadLine().ToLower();
                Console.Clear();
            } while (willContinue == "y");
            


            
            Console.WriteLine("Have a great day!");
            

        }
    }
}
