

namespace CurrencyExchange
{
    internal class CurrencyExchange
    {
        public string FromCode { get;}
        public string ToCode { get; }
        public double Price { get; }
        public double AmountPaid { get; }
        public double AmountReceived { get; }



        public CurrencyExchange(string fromCode, string toCode, double price, double amountPaid, double amountReceived)
        {
            FromCode = fromCode;
            ToCode = toCode;
            Price = price;
            AmountPaid = amountPaid;
            AmountReceived = amountReceived;
        }

    }
}
