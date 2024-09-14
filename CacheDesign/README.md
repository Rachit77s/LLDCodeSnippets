# Cache System

A flexible and extensible caching system with customizable eviction and write strategies, supporting multiple database backends like MySQL and MongoDB. The system allows you to plug in different strategies for eviction and writing based on your requirements.

## Class Diagram

```plaintext
+-------------------------------------+
|               Cache                 |
+-------------------------------------+
| - ttlInMilliseconds: int            |
| - evictionStrategy: IEvictionStrategy|
| - writeStrategy: IWriteStrategy     |
| - db: IDatabase                     |
| - executors: Executor[]             |
| - cacheMap: Map<K, V>               |
+-------------------------------------+
| + put(K key, V value)               |
| + get(K key): V                     |
| + update(K key, V value)            |
| + delete(K key)                     |
+-------------------------------------+

+-------------------------------------+
|          IEvictionStrategy          |
+-------------------------------------+
| + evict(): K                        |
+-------------------------------------+

+-------------------------------------------------+
|       LRUEvictionStrategy : IEvictionStrategy   |
+-------------------------------------------------+
| + evict(): K                                    |
+-------------------------------------------------+

+-------------------------------------------------+
|       LFUEvictionStrategy : IEvictionStrategy   |
+-------------------------------------------------+
| + evict(): K                                    |
+-------------------------------------------------+

+-------------------------------------+
|          IWriteStrategy             |
+-------------------------------------+
| + write()                           |
+-------------------------------------+

+----------------------------------------------------+
|  WriteBackCacheStrategy : IWriteStrategy           |
+----------------------------------------------------+
| + write()                                          |
+----------------------------------------------------+

+-----------------------------------------------------+
|  WriteThroughCacheStrategy : IWriteStrategy         |
+-----------------------------------------------------+
| + write()                                           |
+-----------------------------------------------------+

+-------------------------------------+
|            IDatabase                |
+-------------------------------------+
| + create(K key, V value)            |
| + get(K key): V                     |
| + update(K key, V value)            |
| + delete(K key)                     |
+-------------------------------------+

+-------------------------------------------------+
|       MySQLAdapter : IDatabase                  |
+-------------------------------------------------+
| + create(K key, V value)                        |
| + get(K key): V                                 |
| + update(K key, V value)                        |
| + delete(K key)                                 |
+-------------------------------------------------+

+-------------------------------------------------+
|       MongoDbAdapter : IDatabase                |
+-------------------------------------------------+
| + create(K key, V value)                        |
| + get(K key): V                                 |
| + update(K key, V value)                        |
| + delete(K key)                                 |
+-------------------------------------------------+
