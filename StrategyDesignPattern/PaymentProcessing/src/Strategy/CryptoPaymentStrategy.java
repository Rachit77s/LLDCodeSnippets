package Strategy;

public class CryptoPaymentStrategy implements IPaymentStrategy {
    @Override
    public void ProcessPayment(double amount) {
        System.out.println("Processing crypto payment of amount " + amount);
    }
}
