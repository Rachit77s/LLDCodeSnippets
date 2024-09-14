package databaseadapter;

public interface IDatabaseAdapter<K, V> {
    void create(K key, V value);
    V get(K key);
    void update(K key, V value);
    void delete(K key);
}