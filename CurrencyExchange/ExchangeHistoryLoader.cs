namespace CurrencyExchangeConsole
{
    internal class ExchangeHistoryLoader
    {
        public static void LoadExchanges(List<CurrencyExchange> currencyExchanges, string filePath)
        {
            if (!File.Exists(filePath))
                return;
            
            currencyExchanges.AddRange(
                File.ReadAllLines(filePath)
                    .Select(line => line.Split(','))
                    .Where(values => values.Length >= 5)
                    .Select(values => new CurrencyExchange(values[0], values[1], double.Parse(values[2]), double.Parse(values[3]), double.Parse(values[4]))));
        }
    }
}
