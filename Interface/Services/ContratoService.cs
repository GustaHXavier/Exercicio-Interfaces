using Entities;
using Services;

namespace Services {
    internal class ContratoService {

        private IOnlinePaymentService _ionlinePaymentService;

        public ContratoService(IOnlinePaymentService payPalService) {
            _ionlinePaymentService = payPalService;
        }

        public void ProcessContract(Contrato contrato, int months) {

            double basicQuota = contrato.TotalValue / months;

            for(int i = 1; i <= months; i++) {

                DateTime date = contrato.Date.AddMonths(i);

                double uptadeQuota = basicQuota + _ionlinePaymentService.Interest(basicQuota, i);
                double FinallyQuota = uptadeQuota + _ionlinePaymentService.PaymentFee(uptadeQuota);

                contrato.AddContrato(new Contratos(FinallyQuota, date));

            }
        }
    }
}
