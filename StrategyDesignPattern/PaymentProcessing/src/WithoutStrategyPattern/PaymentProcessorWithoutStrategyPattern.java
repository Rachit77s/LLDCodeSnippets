package WithoutStrategyPattern;

import java.util.Scanner;

public class PaymentProcessorWithoutStrategyPattern {

    public void ProcessPayment(double amount)
    {
        Scanner scanner = new Scanner(System.in);

        System.out.print("Enter something: ");
        String userInput = scanner.nextLine();

        PaymentType paymentType = PaymentType.valueOf(userInput);

        System.out.println("You entered: " + paymentType);
        // double amount = 100.0;

        if (paymentType == PaymentType.CREDIT_CARD) {
            System.out.println("Processing credit card payment of amount " + amount);
        } else if (paymentType == PaymentType.DEBIT_CARD) {
            System.out.println("Processing debit card payment of amount " + amount);
        } else if (paymentType == PaymentType.PAYPAL) {
            System.out.println("Processing PayPal payment of amount " + amount);
        } else {
            throw new IllegalArgumentException("Invalid payment type");
        }

        scanner.close();
    }
}

enum PaymentType {
    CREDIT_CARD,
    DEBIT_CARD,
    PAYPAL
}