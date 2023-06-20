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
                comboBox1.Items.Add(code);
                comboBox2.Items.Add(code);
            }
            comboBox1.SelectedItem = "SEK";
            comboBox2.SelectedItem = "USD";
        }



        List<string> currencyCodes = new List<string>()
            {
                "EUR", "USD", "JPY", "BGN", "CZK", "DKK", "GBP", "HUF", "PLN",
                "RON", "SEK", "CHF", "ISK", "NOK", "TRY", "AUD", "BRL", "CAD",
                "CNY", "HKD", "IDR", "ILS", "INR", "KRW", "MXN", "MYR", "NZD",
                "PHP", "SGD", "THB", "ZAR"
            };






        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       


        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
