package Strategy;

public class PaypalPaymentStrategy implements IPaymentStrategy {
    public void ProcessPayment(double amount) {
        System.out.println("Processing PayPal payment of amount " + amount);
    }
}
