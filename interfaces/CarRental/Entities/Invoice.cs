using System;
using System.Globalization;

namespace Course.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double  basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        private string FormatCurrency(double amount)
        {
            return amount.ToString("F2", CultureInfo.InvariantCulture);
        }

        public override string ToString()
        {
            return "Basic Payment: " + FormatCurrency(BasicPayment)
                + "\nTax: " + FormatCurrency(Tax)
                + "\nTotal Payment: " + FormatCurrency(TotalPayment);
        }
    }
}