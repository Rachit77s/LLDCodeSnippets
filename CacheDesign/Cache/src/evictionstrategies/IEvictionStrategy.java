package evictionstrategies;

public interface IEvictionStrategy<K> {
    K evict();
}
