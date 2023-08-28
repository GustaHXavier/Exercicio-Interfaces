
namespace Services {
    internal class PaypalService : IOnlinePaymentService {

        public double PaymentFee(double amount) {

            return amount * 0.02; 
            
        }

        public double Interest(double amount, int month) {

            return amount * 0.01 * month;
        }
    }
}
