using System.Collections.Generic;

namespace Entities {
    internal class Contrato {

        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Contratos> Contratos { get; set; }

        public Contrato(int number, DateTime date, double totalValue) {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Contratos = new List<Contratos>();
        }

        public void AddContrato(Contratos contratos) {

            Contratos.Add(contratos);
        }
    }
}
