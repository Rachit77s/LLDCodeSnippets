package Adapter;

import Adaptee.IWeighingMachineAdaptee;

public class WeighingMachineConcreteAdapter implements IWeighingMachineAdapter {

    // Talk to the WeighingMachineBabyAdaptee
    IWeighingMachineAdaptee _weighingMachineAdaptee;

    public WeighingMachineConcreteAdapter(IWeighingMachineAdaptee weightMachine) {
        this._weighingMachineAdaptee = weightMachine;
    }

    @Override
    public double getWeightInKg() {
        double weightInPound = _weighingMachineAdaptee.getWeightInPound();

        //Convert it to KGs
        double weightInKg = weightInPound * .45;
        return weightInKg;

    }
}
