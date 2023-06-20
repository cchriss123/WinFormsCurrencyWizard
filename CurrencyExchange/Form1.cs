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



        List<string> currencyCodes = new List<string>()     // Hardcoded list of currency codes to save API calls
            {
                "EUR", "USD", "JPY", "BGN", "CZK", "DKK", "GBP", "HUF", "PLN",
                "RON", "SEK", "CHF", "ISK", "NOK", "TRY", "AUD", "BRL", "CAD",
                "CNY", "HKD", "IDR", "ILS", "INR", "KRW", "MXN", "MYR", "NZD",
                "PHP", "SGD", "THB", "ZAR"
            };



        private void Calculate_Click(object sender, EventArgs e)
        {
            // Needed or else the program will throw a null pointer exception error if the user doesn't select a currency
            if (comboBoxFrom.SelectedItem == null || comboBoxTo.SelectedItem == null)   
            {
                comboBoxFrom.SelectedItem = "SEK";
                comboBoxTo.SelectedItem = "USD";
            }

           
            if (!double.TryParse(textBoxAmount.Text, out double amountInFromCurrency))
            {
                MessageBox.Show("Please enter a valid number for the amount.");
                return;
            }

            string fromCode = comboBoxFrom.SelectedItem.ToString();
            string toCode = comboBoxTo.SelectedItem.ToString();
            double exchangeRate = ExchangeRateProvider.GetExchangeRate(fromCode, toCode);
            double price = Math.Round(1 / exchangeRate, 2); 
            double amountInToCurrency = exchangeRate * amountInFromCurrency;
            Console.WriteLine($"fromCode: {fromCode} | toCode: {toCode} | exchangeRate: {exchangeRate} | price: {price} | amountInToCurrency: {amountInToCurrency}");


           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
