package evictionstrategies.factory;

import enums.EvictionStrategyEnum;
import evictionstrategies.IEvictionStrategy;
import evictionstrategies.LFUEvictionStrategy;
import evictionstrategies.LRUEvictionStrategy;

public class EvictionStrategyFactory { //} implements IEvictionStrategyFactory {

    //@Override
    public static IEvictionStrategy getEvictionStrategyForType(EvictionStrategyEnum evictionStrategy) {
        switch (evictionStrategy) {
            case EvictionStrategyEnum.LRU:
                return new LRUEvictionStrategy();
            case EvictionStrategyEnum.LFU:
                return new LFUEvictionStrategy();
            default:
                return null;
        }
    }
}
