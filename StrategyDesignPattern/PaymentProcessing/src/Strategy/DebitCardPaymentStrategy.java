package Strategy;

public class DebitCardPaymentStrategy implements IPaymentStrategy {
    public void ProcessPayment(double amount) {
        System.out.println("Processing debit card payment of amount " + amount);
    }
}
