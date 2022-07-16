package After;

import java.util.HashMap;

public class ModeOfOutStrategyRegistry {
    private HashMap<OutMode, IOutStrategy> strategies = new HashMap<>();

    public void RegisterModeOfBatsmenGettingOut(OutMode mode, IOutStrategy strategy) {
        strategies.put(mode, strategy);
    }

    public IOutStrategy GetModeOfBatsmenGettingOut(OutMode mode) {
        return strategies.get(mode);
    }
}
