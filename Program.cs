using sample_redis_crud.Redis.Factory;
using sample_redis_crud.Redis.Interface;
using StackExchange.Redis;
using System.Runtime.CompilerServices;

namespace sample_redis_crud
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var redisInstance = RedisFactory.CreateInstance("10.150.27.58", "6379", "Redis2019!");

        }

        static void Insert(this IRedisClient redisInstance, Dictionary<string, string> keysValues)
        {
            foreach (var keyValue in keysValues)
                redisInstance.Database?.StringSet(keyValue.Key, keyValue.Value);
        }
        static void InsertHash(this IRedisClient redisInstance, string key, HashEntry[] hash)
        {
            redisInstance.Database?.HashSet(key, hash);
        }
    }
}