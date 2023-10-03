package UsingStrategyPattern;

import Strategy.*;

public class ProcessPaymentStrategyFactory {

    public IPaymentStrategy GetPaymentStrategyFactory(EnumPaymentType paymentType)
    {
        if (paymentType == EnumPaymentType.CREDIT_CARD) {
            return new CreditCardPaymentStrategy();
        } else if (paymentType == EnumPaymentType.DEBIT_CARD) {
            return new DebitCardPaymentStrategy();
        } else if (paymentType == EnumPaymentType.PAYPAL) {
            return new PaypalPaymentStrategy();
        } else if (paymentType == EnumPaymentType.CRYPTO) {
            return new CryptoPaymentStrategy();
        } else {
            throw new IllegalArgumentException("Invalid payment type");
        }
    }
}
