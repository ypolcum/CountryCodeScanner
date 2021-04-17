// Exam 2, Part 3
// CIS 199-XX
// Spring 2019
// Prompt the user to enter country code and then look up
// matching country name and display. If no match is found,
// display "No Match!" instead.

// By: Andrew L. Wright

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam2EC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string GetCountryName(int countryCode)
        {
            int[] codes = { 1, 44, 354, 91, 353, 81, 53, 27, 52 }; // The country codes
            string[] names = { "United States", "United Kingdom", "Iceland", "India", "Ireland",
                                 "Japan", "Cuba", "South Africa", "Mexico" }; // The associated countries

            string countryName = "No match!"; // Matching country name, assumes not found
            int index = 0;                    // Current position being searched, start at first subscript
            bool found = false;               // Have we found a match yet?

            while (index < codes.Length && !found)
            {
                if (countryCode == codes[index])
                    found = true;
                else
                    ++index;
            }

            if (found)
                countryName = names[index];

            return countryName;
        }

        private void findNameBtn_Click(object sender, EventArgs e)
        {
            int countryCode;
            string countryName;

            if (int.TryParse(codeTxt.Text, out countryCode))
            {
                countryName = GetCountryName(countryCode);
                outputNameLbl.Text = countryName;
            }
            else
            {
                MessageBox.Show("Please enter valid country code!");
            }

        }
    }
}
