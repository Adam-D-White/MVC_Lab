using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CountriesLab
{
    class Country
    {


        public string Name { get; set; }

        public string Continent { set; get; }

        //public string Colors { set; get; }

        public List<string> Colors { set; get; }


        public  Country(string name, string continent, List<string> colors)
        {

            Name = name;
            Continent = continent;
            Colors = colors;
        }


    }
}
