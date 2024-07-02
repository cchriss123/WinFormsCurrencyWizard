using System.Globalization;
using System.IO;

namespace CurrencyExchange
{
    internal class ExchangeHistorySaver
    {
        public static void SaveExchanges(CurrencyExchange exchange, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))   // true to append to file rather than overwrite
            {                
                  writer.WriteLine($"" +
                        $"{exchange.FromCode}," +
                        $"{exchange.ToCode}," +
                        $"{exchange.Price.ToString(CultureInfo.InvariantCulture)}," +           // InvariantCulture to use . instead of , for decimal separator to avoid problems with csv
                        $"{exchange.AmountPaid.ToString(CultureInfo.InvariantCulture)}," +
                        $"{exchange.AmountReceived.ToString(CultureInfo.InvariantCulture)}," +
                        $"{exchange.Date}");
            }
        }
    }
}



