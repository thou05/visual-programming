using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chuong3_CapitalCountry
{
    public partial class Form1 : Form
    {
        string country = "";
        string capital = "";
        List<CountryCapital> listCountryCapital = new List<CountryCapital>();
        public Form1()
        {
            InitializeComponent();
            EmptyOption();
            addData();
        }
    

        private void addData()
        {
            listCountryCapital.Add(new CountryCapital("France", "Paris"));
            listCountryCapital.Add(new CountryCapital("Germany", "Berlin"));
            listCountryCapital.Add(new CountryCapital("Italy", "Rome"));
            listCountryCapital.Add(new CountryCapital("United Kingdom", "London"));
            listCountryCapital.Add(new CountryCapital("United States", "Washington, D.C"));
            listCountryCapital.Add(new CountryCapital("Canada", "Ottawa"));
            listCountryCapital.Add(new CountryCapital("Russia", "Moscow"));
            listCountryCapital.Add(new CountryCapital("Viet Nam", "Ha Noi"));
        }

        private void EmptyOption()
        {
            foreach (RadioButton rdo in grpCountry.Controls.OfType<RadioButton>())
            {
                rdo.Checked = false;
            }

            // Bỏ tick trong group Capital
            foreach (RadioButton rdo in grpCapital.Controls.OfType<RadioButton>())
            {
                rdo.Checked = false;
            }
            capital = "";
            country = "";
            lbYeuCau.Text = "Hãy chọn quốc gia";

        }

        private string getNotification(string country)
        {
            EmptyOption();
            return "Hãy chọn thành phố cho " + country;
        }


        bool check(string country, string capital)
        {
            foreach(CountryCapital i  in listCountryCapital)
            {
                if(i.Country.Equals(country) && i.Capital.Equals(capital))
                {
                    return true;
                }
            }
            return false;
        }



        private void grpCountry_Enter(object sender, EventArgs e)
        {

        }

        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rdo = (RadioButton)sender;
            if(rdo == null || !rdo.Checked)
            {
                return;
            }

            if (grpCountry.Controls.Contains(rdo))
            {
                country = rdo.Text;
                lbYeuCau.Text = "Hãy chọn thủ đô cho " + country;
            }

            if(grpCapital.Controls.Contains(rdo))
            {
                capital = rdo.Text;
                if (check(country, capital))
                {
                    lbYeuCau.Text = ("Chuc mung, thu do cua " + country + " la " + capital);
                }
                else
                {
                    lbYeuCau.Text = ("Sai roi, thu do cua " + country + " khong phai la " + capital);
                }
            }
        }
    }
}
