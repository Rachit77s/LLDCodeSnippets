import After.*;

public class Program {
    public static void main(String[] args) {
        //System.out.printf("Hey");
        ModeOfOutStrategyRegistry modeOfOutCalculationStrategyRegistry = new ModeOfOutStrategyRegistry();
        modeOfOutCalculationStrategyRegistry.RegisterModeOfBatsmenGettingOut(
                OutMode.LBW, new LBWStrategy()
        );
        modeOfOutCalculationStrategyRegistry.RegisterModeOfBatsmenGettingOut(
                OutMode.HITWICKET, new HitWicketStrategy()
        );

        Umpire onFieldUmpire = new Umpire(modeOfOutCalculationStrategyRegistry);
        onFieldUmpire.GetBatsmenModeOfGettingOut(OutMode.LBW);
    }
}
