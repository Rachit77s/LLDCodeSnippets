import cachewritestrategies.IWriteStrategy;
import databaseadapter.IDatabaseAdapter;
import enums.EvictionStrategyEnum;
import enums.WriteStrategyEnum;
import evictionstrategies.IEvictionStrategy;

import java.util.Map;

public class Cache<K, V> {
    private IWriteStrategy writeStrategy;
    private IEvictionStrategy evictionStrategy;
    private IDatabaseAdapter<K, V> database;
    int ttlInMilliseconds;
    private Map<K, V> cacheMap;

    public Cache(EvictionStrategyEnum evictionStrategy,
                 WriteStrategyEnum writeStrategy,
                 int ttlInMilliseconds,
                 IDatabaseAdapter<K, V> database) {
//        this.writeStrategy = WriteStrategyFactory.getWriteStrategy(writeStrategy);
//        this.evictionStrategy = EvictionStrategyFactory.getEvictionStrategy(evictionStrategy);
        this.database = database;
        this.ttlInMilliseconds = ttlInMilliseconds;
    }
}
