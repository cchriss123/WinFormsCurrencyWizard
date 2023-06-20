using System.Collections.Generic;
using System.IO;

namespace CurrencyExchange
{
    internal class ExchangeHistorySaver
    {
        public static void SaveExchanges(List<CurrencyExchange> currencyExchanges, string filePath)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (CurrencyExchange exchange in currencyExchanges)                
                    writer.WriteLine($"{exchange.FromCode},{exchange.ToCode},{exchange.Price},{exchange.AmountPaid},{exchange.AmountReceived}");                
            }
        }
    }
}
