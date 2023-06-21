using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace CurrencyExchange
{
    internal class ExchangeHistoryLoader
    {
        public static void LoadExchanges(List<CurrencyExchange> currencyExchanges, string filePath)
        {
            if (!File.Exists(filePath))
                return;

            var cultureInfo = CultureInfo.InvariantCulture;

            // cultureInfo to use . instead of , for decimal separator to avoid problems with csv,
            // NumberStyles.Float is needed to parse numbers with . as decimal separator in conjunction with cultureInfo and double.TryParse
            // Using parse rather than try parse so that the user cant make the program crash by entering invalid data in the csv file.
            // Tenary operator will set value to 0 if parsing fails.
         
            currencyExchanges.AddRange(
                File.ReadAllLines(filePath)
                    .Select(line => line.Split(','))
                    .Where(values => values.Length == 6)
                    .Select(values => new CurrencyExchange(
                        values[0],
                        values[1],
                        double.TryParse(values[2], NumberStyles.Float, cultureInfo, out var price) ? price : 0, 
                        double.TryParse(values[3], NumberStyles.Float, cultureInfo, out var amountPaid) ? amountPaid : 0, 
                        double.TryParse(values[4], NumberStyles.Float, cultureInfo, out var amountReceived) ? amountReceived : 0, 
                        values[5])));


        }
    }
}
