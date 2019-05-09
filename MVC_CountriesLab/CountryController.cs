using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CountriesLab
{
    class CountryController
    {

        

        public void CountryAction(Country c)
        {
            CountryView countryView = new CountryView(c);
            countryView.Display();
        }
        public void WelcomeAction()
        {
            CountryDataBase countryDB = new CountryDataBase();

            CountryListView countryListView = new CountryListView(countryDB.Countries);
            Console.WriteLine("\t\tHello, and welcome to the country app!\n" +
                "\n" +
                "Please select a country from the following list:\n" +
                "");
                 countryListView.Display();

            int selection = int.Parse(Console.ReadLine());
            CountryAction(countryDB.Countries[selection - 1]);
            
        }



    }
}
