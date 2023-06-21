

namespace CurrencyExchange
{
    internal class CurrencyExchange
    {
        public string FromCode { get;}
        public string ToCode { get; }
        public double Price { get; }
        public double AmountPaid { get; }
        public double AmountReceived { get; }
        public string Date { get; set; }


        public CurrencyExchange(string fromCode, string toCode, double price, double amountPaid, double amountReceived)
        {
            FromCode = fromCode;
            ToCode = toCode;
            Price = price;
            AmountPaid = amountPaid;
            AmountReceived = amountReceived;
            Date = System.DateTime.Now.ToString("yyyy-MM-dd");
        }


        public override string ToString()
        {
            return $"Date: {Date} | From: {FromCode} | To: {ToCode} | Price: {Price} | Amount Paid: {AmountPaid} | Amount Received: {AmountReceived}";
        }

    }
}
