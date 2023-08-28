using System.Globalization;

namespace Entities {
    internal class Contratos {

        public double Amount { get; set; }
        public DateTime DueDate { get; set; }

        public Contratos(double amount, DateTime dueDate) {
            Amount = amount;
            DueDate = dueDate;
        }

        public override string ToString() {
            return DueDate.ToString("dd/MM/yyyy")
                + " - "
                + Amount.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
