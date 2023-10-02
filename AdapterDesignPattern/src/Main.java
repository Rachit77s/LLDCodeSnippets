import Adaptee.WeighingMachineForBabiesAdaptee;
import Adapter.IWeighingMachineAdapter;
import Adapter.WeighingMachineConcreteAdapter;

// Press Shift twice to open the Search Everywhere dialog and type `show whitespaces`,
// then press Enter. You can now see whitespace characters in your code.
public class Main {
    public static void main(String[] args) {
        // Press Opt+Enter with your caret at the highlighted text to see how
        // IntelliJ IDEA suggests fixing it.

        /*
            We have Adaptee class which returns the weight in Pounds. This is 3rd party class code.
            And the client wants the weight in Kg. But the client cannot directly interact with Adaptee class
            as Adaptee class return the weight in Pounds, however, client demands weight in Kg's.
            Therefore, we will create an Adapter interface and the client class will interact with Adapter interface.
            In the Adapter interface we will put the methods that client demands(WeightInKG), and we will
            create a ConcreteAdapter class that will directly talk with the Adaptee(3rd party code) and
            convert the WtInPounds to WtInKg and serve it to the client class.

         */

        // This is Client code class
        // Client code calls the Adapter Interface

        // Use Adapter i/f reference and create the obj of ConcreteAdapter class and get required functionality.
        IWeighingMachineAdapter adapter = new WeighingMachineConcreteAdapter(new WeighingMachineForBabiesAdaptee());
        System.out.println(adapter.getWeightInKg());
    }
}