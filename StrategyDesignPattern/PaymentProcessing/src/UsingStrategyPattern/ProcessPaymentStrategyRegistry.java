package UsingStrategyPattern;

import Strategy.*;

import java.util.HashMap;

public class ProcessPaymentStrategyRegistry {
    private HashMap<EnumPaymentType, IPaymentStrategy> paymentStrategies = new HashMap<>();

    // Not required if we are setting up the strategies through the main class
//    public ProcessPaymentStrategyRegistry()
//    {
//        paymentStrategies.put(EnumPaymentType.CREDIT_CARD, new CreditCardPaymentStrategy());
//        paymentStrategies.put(EnumPaymentType.DEBIT_CARD, new DebitCardPaymentStrategy());
//        paymentStrategies.put(EnumPaymentType.PAYPAL, new PaypalPaymentStrategy());
//        paymentStrategies.put(EnumPaymentType.CRYPTO, new CryptoPaymentStrategy());
//    }

    // This method can also be known as SetPaymentStrategy
    public void RegisterPaymentStrategy(EnumPaymentType enumPaymentType, IPaymentStrategy strategy) {
        paymentStrategies.put(enumPaymentType, strategy);
    }

    public IPaymentStrategy GetPaymentStrategy(EnumPaymentType enumPaymentType) {
        return paymentStrategies.get(enumPaymentType);
    }
}
