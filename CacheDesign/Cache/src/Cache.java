import cachewritestrategies.IWriteStrategy;
import cachewritestrategies.factory.WriteStrategyFactory;
import databaseadapter.IDatabaseAdapter;
import enums.EvictionStrategyEnum;
import enums.WriteStrategyEnum;
import evictionstrategies.IEvictionStrategy;
import evictionstrategies.factory.EvictionStrategyFactory;
import exception.KeyNotFoundException;
import exception.StorageFullException;

import java.util.Map;
import java.util.concurrent.ConcurrentHashMap;

public class Cache<K, V> {
    private IWriteStrategy writeStrategy;
    private IEvictionStrategy evictionStrategy;
    private IDatabaseAdapter<K, V> databaseSource;
    int ttlInMilliseconds;
    int sizeOfCache;
    private Map<K, V> concurrentCacheHashMap = new ConcurrentHashMap<K, V>();

    public Cache(EvictionStrategyEnum evictionStrategy,
                 WriteStrategyEnum writeStrategy,
                 IDatabaseAdapter<K, V> database,
                 int ttlInMilliseconds,
                 int sizeOfCache) {

        // Here ideally use Interface to interact, but for now using factory class directly
        this.writeStrategy = WriteStrategyFactory.getWriteStrategy(writeStrategy);
        this.evictionStrategy = EvictionStrategyFactory.getEvictionStrategyForType(evictionStrategy);
        this.databaseSource = database;
        this.ttlInMilliseconds = ttlInMilliseconds;
        this.sizeOfCache = sizeOfCache;
    }

    // CRUD
    // Old Way
//    public void put(K key, V value) {
//        try {
//            if(!concurrentCacheMap.containsKey(key) && concurrentCacheMap.size() > mapThreshHoldSize) {
//                evictionStrategy.evict();
//            }
//
//            if(concurrentCacheMap.containsKey(key)) {
//                // update the cache
//
//                if(writeStrategy.equals(WriteStrategyEnum.WRITE_THROUGH)) {
//                    databaseSource.update(key, value);
//                    concurrentCacheMap.put(key, value);
//                } else if (writeStrategy.equals(WriteStrategyEnum.WRITE_BACK)) {
//                    // First save the data in the cache
//                    concurrentCacheMap.put(key, value);
//                    // Wait for some time and then push to the DB
//                    databaseSource.update(key, value);
//                }
//            } else {
//                // add new key
//                 databaseSource.create(key, value);
//                 concurrentCacheMap.put(key, value);
//            }
//        } catch (StorageFullException storageFullException) {
//            System.out.println("Got storage full! Trying to evict");
//        }
//    }

    public void put(K key, V value) {
        try {
            if(!concurrentCacheHashMap.containsKey(key) && concurrentCacheHashMap.size() > sizeOfCache) {
                evictionStrategy.evict();
            }

            // add or update the key
            writeStrategy.write(key, value);
        } catch (StorageFullException storageFullException) {
            System.out.println("Got storage full! Trying to evict");
        }
    }

    public V get(K key) {
        try {
            if(concurrentCacheHashMap.containsKey(key)) {
                return concurrentCacheHashMap.get(key);
            } else {
                return databaseSource.get(key);
            }
        } catch (KeyNotFoundException keyNotFoundException) {
            System.out.println("Hit a cache miss  for key " + key);
            throw new KeyNotFoundException("Key not found");
        }
    }

    public void update(K key, V value) {
    }

    public void remove(K key) {
    }
}
