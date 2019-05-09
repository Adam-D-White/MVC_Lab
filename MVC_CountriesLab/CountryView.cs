using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CountriesLab
{
    class CountryView 
    {
        public Country DisplayCountry { get; set; }

        public CountryView(Country _displayCountry)
        {
            DisplayCountry = _displayCountry;
        }
        
        
        public void Display()
        {

            Console.WriteLine("  \n" +
                "Country : " + DisplayCountry.Name);
            Console.WriteLine("Continent : " + DisplayCountry.Continent);
            foreach (string color in DisplayCountry.Colors)
            { Console.WriteLine("Country Flag Colors : " + color); }
        }



    }
}
