using sample_redis_crud.Redis.Interface;
using sample_redis_crud.Redis.Models;

namespace sample_redis_crud.Redis.Factory
{
    public static class RedisFactory
    {
        public static IRedisClient CreateInstance(string url, string port, string pass)
            => new RedisClient(url, port, pass);
    }
}
