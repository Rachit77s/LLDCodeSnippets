package cachewritestrategies;

public interface IWriteStrategy<K,V> {
    void write(K key, V value);
}
