using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;

using System.Windows.Forms;

namespace CurrencyExchange
{
    public partial class Form1 : Form
    {

        private string fromCode;
        private string toCode;
        private double exchangeRate;
        private double price;
        private double amountInFromCurrency;
        private double amountInToCurrency;

        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "exchange_history.csv");

        List<CurrencyExchange> currencyExchanges = new List<CurrencyExchange>();
        
        List<string> currencyCodes = new List<string>()     // Hardcoded list of currency codes to save API calls
            {
                "EUR", "USD", "JPY", "BGN", "CZK", "DKK", "GBP", "HUF", "PLN",
                "RON", "SEK", "CHF", "ISK", "NOK", "TRY", "AUD", "BRL", "CAD",
                "CNY", "HKD", "IDR", "ILS", "INR", "KRW", "MXN", "MYR", "NZD",
                "PHP", "SGD", "THB", "ZAR"
            };
        
        

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e) // Runs when the program starts
        {
            foreach (string code in currencyCodes)
            {
                comboBoxFrom.Items.Add(code);
                comboBoxTo.Items.Add(code);
            }
            comboBoxFrom.SelectedItem = "SEK";
            comboBoxTo.SelectedItem = "USD";
            ExchangeHistoryLoader.LoadExchanges(currencyExchanges, filePath); 

            var reversedLines = currencyExchanges.Select(exchange => exchange.ToString()).Reverse();
            textBoxHistory.Text = string.Join("\r\n", reversedLines);

        }




        private void Calculate_Click(object sender, EventArgs e)
        {

            if (!double.TryParse(textBoxAmount.Text, out amountInFromCurrency))
            {
                MessageBox.Show("Please enter a valid number for the amount.");
                return;
            }


            // Needed or else the program will throw a null pointer exception error if the user doesn't select a currency
            if (comboBoxFrom.SelectedItem == null || comboBoxTo.SelectedItem == null)   
            {
                comboBoxFrom.SelectedItem = "SEK";
                comboBoxTo.SelectedItem = "USD";
                return;
            }

           
 
            fromCode = comboBoxFrom.SelectedItem.ToString();
            toCode = comboBoxTo.SelectedItem.ToString();
            exchangeRate = ExchangeRateProvider.GetExchangeRate(fromCode, toCode);
            price = Math.Round(1 / exchangeRate, 2); 
            amountInToCurrency = Math.Round(exchangeRate * amountInFromCurrency, 2);            
            textBoxResult.Text = $"From: {fromCode} | To: {toCode} | price: {price} | amount paid: {amountInFromCurrency} | amount recived: {amountInToCurrency}";


        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            if (exchangeRate == 0)
            {
                MessageBox.Show("Please calculate the exchange rate first.");
                return;
            }


            CurrencyExchange currencyExchange = new CurrencyExchange(fromCode, toCode, price, amountInFromCurrency, amountInToCurrency, System.DateTime.Now.ToString("yyyy-MM-dd"));
            currencyExchanges.Add(currencyExchange);
            ExchangeHistorySaver.SaveExchanges(currencyExchange, filePath);
            var reversedLines = currencyExchanges.Select(exchange => exchange.ToString()).Reverse();
            textBoxHistory.Text = string.Join("\r\n", reversedLines);

        }


    }
}
