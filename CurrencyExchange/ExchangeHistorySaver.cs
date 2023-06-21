using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace CurrencyExchange
{
    internal class ExchangeHistorySaver
    {
        public static void SaveExchanges(List<CurrencyExchange> currencyExchanges, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath, true))   // true to append to file rather than overwrite
            {
                foreach (CurrencyExchange exchange in currencyExchanges)                
                    writer.WriteLine($"" +
                        $"{exchange.FromCode}," +
                        $"{exchange.ToCode}," +
                        $"{exchange.Price.ToString(CultureInfo.InvariantCulture)}," +           // InvariantCulture to use . instead of , for decimal separator to avoid problems with csv
                        $"{exchange.AmountPaid.ToString(CultureInfo.InvariantCulture)}," +
                        $"{exchange.AmountReceived.ToString(CultureInfo.InvariantCulture)}");                
            }
        }
    }
}



