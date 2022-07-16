package After;

public class Umpire {
    ModeOfOutStrategyRegistry registry = new ModeOfOutStrategyRegistry();

    public Umpire(ModeOfOutStrategyRegistry registry)
    {
        this.registry = registry;
    }

    public boolean GetBatsmenModeOfGettingOut(OutMode mode) {
        IOutStrategy outStrategy = registry.GetModeOfBatsmenGettingOut(mode);
        outStrategy.GetModeOfOut();
        return true;
    }
}
