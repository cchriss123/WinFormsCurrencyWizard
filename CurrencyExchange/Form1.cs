using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (string code in currencyCodes)
            {
                comboBoxFrom.Items.Add(code);
                comboBoxTo.Items.Add(code);
            }
            comboBoxFrom.SelectedItem = "SEK";
            comboBoxTo.SelectedItem = "USD";
        }



        List<string> currencyCodes = new List<string>()
            {
                "EUR", "USD", "JPY", "BGN", "CZK", "DKK", "GBP", "HUF", "PLN",
                "RON", "SEK", "CHF", "ISK", "NOK", "TRY", "AUD", "BRL", "CAD",
                "CNY", "HKD", "IDR", "ILS", "INR", "KRW", "MXN", "MYR", "NZD",
                "PHP", "SGD", "THB", "ZAR"
            };



        private void Calculate_Click(object sender, EventArgs e)
        {
            if (comboBoxFrom.SelectedItem == null || comboBoxTo.SelectedItem == null)
            {
                comboBoxFrom.SelectedItem = "SEK";
                comboBoxTo.SelectedItem = "USD";
            }

            if (!double.TryParse(textBoxAmount.Text, out double amount))
            {
                MessageBox.Show("Please enter a valid number for the amount.");
                return;
            }           
        }

        private void textBoxAmount_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
