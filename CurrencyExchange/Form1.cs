using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
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

        private string fromCode;
        private string toCode;
        private double exchangeRate;
        private double price;
        private double amountInFromCurrency;
        private double amountInToCurrency;
        List<CurrencyExchange> currencyExchanges = new List<CurrencyExchange>();
        List<string> currencyCodes = new List<string>()     // Hardcoded list of currency codes to save API calls
            {
                "EUR", "USD", "JPY", "BGN", "CZK", "DKK", "GBP", "HUF", "PLN",
                "RON", "SEK", "CHF", "ISK", "NOK", "TRY", "AUD", "BRL", "CAD",
                "CNY", "HKD", "IDR", "ILS", "INR", "KRW", "MXN", "MYR", "NZD",
                "PHP", "SGD", "THB", "ZAR"
            };
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "exchange_history.csv");





        private void Calculate_Click(object sender, EventArgs e)
        {
            // Needed or else the program will throw a null pointer exception error if the user doesn't select a currency
            if (comboBoxFrom.SelectedItem == null || comboBoxTo.SelectedItem == null)   
            {
                comboBoxFrom.SelectedItem = "SEK";
                comboBoxTo.SelectedItem = "USD";
            }

           
            if (!double.TryParse(textBoxAmount.Text, out amountInFromCurrency))
            {
                MessageBox.Show("Please enter a valid number for the amount.");
                return;
            }

            fromCode = comboBoxFrom.SelectedItem.ToString();
            toCode = comboBoxTo.SelectedItem.ToString();
            exchangeRate = ExchangeRateProvider.GetExchangeRate(fromCode, toCode);
            price = Math.Round(1 / exchangeRate, 2); 
            amountInToCurrency = Math.Round(exchangeRate * amountInFromCurrency, 2);            
            textBoxResult.Text = $"From: {fromCode} | To: {toCode} | price: {price} | amount paid: {amountInFromCurrency} | amount recived: {amountInToCurrency}";

            Console.WriteLine($"fromCode:{fromCode} | toCode: {toCode} | exchangeRate: {exchangeRate} | price: {price} | amountInToCurrency: {amountInToCurrency}");


        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            
            if(exchangeRate == 0)
            {
                MessageBox.Show("Please calculate the exchange rate first.");
                return;
            }



            CurrencyExchange currencyExchange = new CurrencyExchange(fromCode, toCode, price, amountInFromCurrency, amountInToCurrency);
            currencyExchanges.Add(currencyExchange);
            ExchangeHistorySaver.SaveExchanges(currencyExchange, filePath);
            textBoxHistory.Text = string.Join("\r\n", currencyExchanges.Select(exchange => exchange.ToString()));

        }





        private void Form1_Load(object sender, EventArgs e)
        {

        }


    }
}
