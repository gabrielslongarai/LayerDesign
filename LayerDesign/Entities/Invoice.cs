using System.Globalization;

namespace LayerDesign.Entities
{
    class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPyament
        {
            get
            {
                return BasicPayment + Tax;
            }
        }

        public override string ToString()
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            return $"Basic Payment: {BasicPayment:F2}" +
                   $"\nTax: {Tax:F2}" +
                   $"\nTotalPayment {TotalPyament:F2}";

        }
    }
}
