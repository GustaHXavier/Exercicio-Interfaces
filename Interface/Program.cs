using System.Globalization;
using Entities;
using System.Globalization;
using Services;


namespace Interface {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Dados do contrato:");
            Console.Write("Entre com o número: ");
            int num = int.Parse(Console.ReadLine());

            Console.Write("Entre com a data do contrato: (dd/MM/yyyy) ");
            DateTime data = DateTime.Parse(Console.ReadLine());

            Console.Write("VALOR DO CONTRATO: ");
            double value = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Numero de parcelas: ");
            int installment = int.Parse(Console.ReadLine());

            Contrato contrato = new Contrato(num, data, value);
            ContratoService service = new ContratoService(new PaypalService());
            service.ProcessContract(contrato, installment);

            Console.WriteLine("CONTRATOS");

            foreach (Contratos contratos in contrato.Contratos) {
                Console.WriteLine(contratos);
            }
        }
    }

}
