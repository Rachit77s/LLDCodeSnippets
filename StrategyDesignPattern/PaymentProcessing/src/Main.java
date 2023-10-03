import Strategy.CreditCardPaymentStrategy;
import Strategy.CryptoPaymentStrategy;
import Strategy.DebitCardPaymentStrategy;
import Strategy.PaypalPaymentStrategy;
import UsingStrategyPattern.EnumPaymentType;
import UsingStrategyPattern.ProcessPaymentMainClass;
import UsingStrategyPattern.ProcessPaymentStrategyFactory;
import UsingStrategyPattern.ProcessPaymentStrategyRegistry;
import WithoutStrategyPattern.PaymentProcessorWithoutStrategyPattern;

public class Main {
    public static void main(String[] args) {

        // Before Strategy Pattern
        // PaymentProcessorWithoutStrategyPattern beforeObj = new PaymentProcessorWithoutStrategyPattern();
        // beforeObj.ProcessPayment(100);

        // After Strategy Pattern
        // Using Factory in Strategy
//        ProcessPaymentStrategyFactory factoryObj = new ProcessPaymentStrategyFactory();
//        ProcessPaymentMainClass obj = new ProcessPaymentMainClass(factoryObj);
//
//        // Pass the required strategy for the payment along with the amount
//        obj.ProcessPayment(EnumPaymentType.CREDIT_CARD, 100);

        // Strategy Pattern Recommended Code to follow

        // Register the different strategies in the Strategy Registry HashMap
        ProcessPaymentStrategyRegistry registryObj = new ProcessPaymentStrategyRegistry();
        registryObj.RegisterPaymentStrategy(EnumPaymentType.CREDIT_CARD, new CreditCardPaymentStrategy());
        registryObj.RegisterPaymentStrategy(EnumPaymentType.DEBIT_CARD, new DebitCardPaymentStrategy());
        registryObj.RegisterPaymentStrategy(EnumPaymentType.PAYPAL, new PaypalPaymentStrategy());
        registryObj.RegisterPaymentStrategy(EnumPaymentType.CRYPTO, new CryptoPaymentStrategy());

        // Call the ProcessPaymentMainClass that will internally call the registry to pick out the strategy to use
        ProcessPaymentMainClass processPaymentMainObj = new ProcessPaymentMainClass(registryObj);

        // Pass the required strategy for the payment along with the amount\
        processPaymentMainObj.ProcessPayment(EnumPaymentType.CRYPTO, 100);

    }
}


/*
    Create a IPaymentStrategy Strategy Interface and subclasses that implements its method.
    Create a ProcessPaymentStrategyRegistry class that stores all the available strategies of payment in its HashMap.
    Create ProcessPaymentMainClass that will invoke the ProcessPaymentStrategyRegistry class and get the
    strategy and finally process the payment.
    Now from the Main method we will register all the strategies and create the object of ProcessPaymentMainClass that
    will call its ProcessPayment method and will get the required payment done for the specified payment method.
 */

