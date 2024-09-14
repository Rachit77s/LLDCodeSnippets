package cachewritestrategies.factory;

import cachewritestrategies.IWriteStrategy;
import enums.WriteStrategyEnum;

public interface IWriteStrategyFactory {
    IWriteStrategy getWriteStrategy(WriteStrategyEnum writeStrategy);
}
