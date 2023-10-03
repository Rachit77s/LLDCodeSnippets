package UsingStrategyPattern;

import Strategy.IPaymentStrategy;

public class ProcessPaymentMainClass {

    // We can't call strategy method directly as we need to create obj of FactoryClass
    // As factory in turn creates the obj of the required strategy
//    public void processPayment(double amount) {
//        paymentStrategy.processPayment(amount);
//    }

    // Using Factory Pattern: Not optimised code as object is created every time the request comes.
//    ProcessPaymentStrategyFactory _paymentStrategyFactory;
//
//    public ProcessPaymentMainClass(ProcessPaymentStrategyFactory strategyFactory) {
//        this._paymentStrategyFactory = strategyFactory;
//    }
//
//    public void ProcessPayment(EnumPaymentType enumPaymentType, double amount) {
//        // Get the Payment Strategy
//        IPaymentStrategy paymentStrategy = _paymentStrategyFactory.GetPaymentStrategyFactory(enumPaymentType);
//
//        // Call the function to process payment
//        paymentStrategy.ProcessPayment(amount);
//    }

    // Using Registry or Context to set strategies object
    ProcessPaymentStrategyRegistry _paymentStrategyRegistry;

    public ProcessPaymentMainClass(ProcessPaymentStrategyRegistry paymentStrategyRegistry) {
        this._paymentStrategyRegistry = paymentStrategyRegistry;
    }

    public void ProcessPayment(EnumPaymentType enumPaymentType, double amount) {
        // Get the Payment Strategy using the Enum from the Registry HashMap
        IPaymentStrategy paymentStrategy = _paymentStrategyRegistry.GetPaymentStrategy(enumPaymentType);

        // Call the function to process payment
        paymentStrategy.ProcessPayment(amount);
    }
}


