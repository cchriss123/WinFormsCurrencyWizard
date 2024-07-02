using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Windows.Forms;

namespace CurrencyExchange
{
    public class ExchangeRateProvider
    {

        public static double GetExchangeRate(string fromCode, string toCode)
        {
            string apiKey = "nk*****************************";
            string urlString = "https://anyapi.io/api/v1/exchange/rates?base=" + fromCode.ToUpper() + "&apiKey=" + apiKey;
            HttpClient client = new HttpClient();
            HttpResponseMessage response = client.GetAsync(urlString).Result;

            if (response.IsSuccessStatusCode)
            {
                string result = response.Content.ReadAsStringAsync().Result;
                JObject json = JObject.Parse(result);
                double rate = (double)json["rates"][toCode];
                Console.WriteLine(json.ToString());
                return rate;
            }
            else
            {
                MessageBox.Show("Error: Unable to fetch data from the API. Response code: " + response.StatusCode);
                return 0;
            }
        }

    }
}
