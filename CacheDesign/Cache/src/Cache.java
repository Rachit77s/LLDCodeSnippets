import cachewritestrategies.IWriteStrategy;
import cachewritestrategies.factory.IWriteStrategyFactory;
import cachewritestrategies.factory.WriteStrategyFactory;
import databaseadapter.IDatabaseAdapter;
import enums.EvictionStrategyEnum;
import enums.WriteStrategyEnum;
import evictionstrategies.IEvictionStrategy;
import evictionstrategies.factory.EvictionStrategyFactory;

import java.util.Map;

public class Cache<K, V> {
    private IWriteStrategy writeStrategy;
    private IEvictionStrategy evictionStrategy;
    private IDatabaseAdapter<K, V> database;
    int ttlInMilliseconds;
    private Map<K, V> cacheMap;

    public Cache(EvictionStrategyEnum evictionStrategy,
                 WriteStrategyEnum writeStrategy,
                 IDatabaseAdapter<K, V> database,
                 int ttlInMilliseconds) {

        // Here ideally use Interface to interact, but for now using factory class directly
        this.writeStrategy = WriteStrategyFactory.getWriteStrategy(writeStrategy);
        this.evictionStrategy = EvictionStrategyFactory.getEvictionStrategyForType(evictionStrategy);
        this.database = database;
        this.ttlInMilliseconds = ttlInMilliseconds;
    }
}
