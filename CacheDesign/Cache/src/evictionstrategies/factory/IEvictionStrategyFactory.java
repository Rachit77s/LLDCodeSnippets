package evictionstrategies.factory;

import enums.EvictionStrategyEnum;
import evictionstrategies.IEvictionStrategy;

public interface IEvictionStrategyFactory {
    IEvictionStrategy getEvictionStrategyForType(EvictionStrategyEnum evictionStrategy);
}
