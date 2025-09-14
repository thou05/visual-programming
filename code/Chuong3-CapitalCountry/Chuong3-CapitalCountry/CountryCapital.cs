using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong3_CapitalCountry
{
    internal class CountryCapital
    {
        string country;
        string capital;
        public CountryCapital(string country, string capital)
        {
            this.country = country;
            this.capital = capital;
        }
        public string Country { get => country; set => country = value; }
        public string Capital { get => capital; set => capital = value; }
    }
}
