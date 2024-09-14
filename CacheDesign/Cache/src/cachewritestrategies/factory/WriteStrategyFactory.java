package cachewritestrategies.factory;

import cachewritestrategies.IWriteStrategy;
import cachewritestrategies.WriteBackCacheStrategy;
import cachewritestrategies.WriteThroughCacheStrategy;
import enums.WriteStrategyEnum;

public class WriteStrategyFactory { //} implements IWriteStrategyFactory {

    //@Override
    public static IWriteStrategy getWriteStrategy(WriteStrategyEnum writeStrategy) {
        switch (writeStrategy) {
            case WriteStrategyEnum.WRITE_THROUGH:
                return new WriteThroughCacheStrategy();
            case WriteStrategyEnum.WRITE_BACK:
                return new WriteBackCacheStrategy();
            default:
                return null;
        }
    }
}
