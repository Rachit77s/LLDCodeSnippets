package Strategy;

public class CreditCardPaymentStrategy implements IPaymentStrategy {
    public void ProcessPayment(double amount) {
        System.out.println("Processing credit card payment of amount " + amount);
    }
}
