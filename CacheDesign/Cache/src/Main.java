import databaseadapter.MySQLAdapter;
import enums.EvictionStrategyEnum;
import enums.WriteStrategyEnum;

public class Main {
    public static void main(String[] args) {
        System.out.println("Hello world!");

        // Here we can use Builder pattern as well for the constructor
        Cache cacheObj = new Cache(EvictionStrategyEnum.LRU,
                WriteStrategyEnum.WRITE_THROUGH,
                new MySQLAdapter<>(),
                3600);
        
        cacheObj.put("Rachit", 1);
        cacheObj.put("Rachit Srivastava", 2);

        System.out.println("Cache initialized!");
        System.out.println("Bye world!");
    }
}