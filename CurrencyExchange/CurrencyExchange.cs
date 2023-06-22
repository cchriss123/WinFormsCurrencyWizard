

using System.Globalization;

namespace CurrencyExchange
{
    internal class CurrencyExchange
    {
        public string FromCode { get; set; }
        public string ToCode { get; set; }
        public double Price { get; set; }
        public double AmountPaid { get; set; }
        public double AmountReceived { get; set; }
        public string Date { get; set; }


        public CurrencyExchange(string fromCode, string toCode, double price, double amountPaid, double amountReceived, string date)
        {
            FromCode = fromCode;
            ToCode = toCode;
            Price = price;
            AmountPaid = amountPaid;
            AmountReceived = amountReceived;
            Date = date;
        }


            public override string ToString()
            {
                return $"Date: {Date} | From: {FromCode} | To: {ToCode} | Price: {Price} | Amount Paid: {AmountPaid} | Amount Received: {AmountReceived}";
            }

    }
}
