package databaseadapter;

public class MongoDbAdapter<K, V> implements IDatabaseAdapter<K, V>  {
    /**
     * @param key
     * @param value
     */
    @Override
    public void create(K key, V value) {

    }

    /**
     * @param key
     * @return
     */
    @Override
    public V get(K key) {
        return null;
    }

    /**
     * @param key
     * @param value
     */
    @Override
    public void update(K key, V value) {

    }

    /**
     * @param key
     */
    @Override
    public void delete(K key) {

    }
}
