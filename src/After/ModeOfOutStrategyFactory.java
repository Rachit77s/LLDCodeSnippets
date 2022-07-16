package After;

public class ModeOfOutStrategyFactory {

    IOutStrategy GetModeOfOutStrategy(OutMode mode)
    {
        if (mode == OutMode.LBW){
            return new LBWStrategy();
        } else if (mode == OutMode.HITWICKET) {
            return new HitWicketStrategy();
        }

        return null;
    }
}
