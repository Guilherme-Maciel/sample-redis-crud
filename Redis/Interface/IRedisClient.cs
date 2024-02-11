using StackExchange.Redis;

namespace sample_redis_crud.Redis.Interface
{
    public interface IRedisClient
    {
        string Url { get; }
        string Port { get; }
        string Pass { get; }
        ConfigurationOptions? Options { get; }
        ConnectionMultiplexer? Connection { get; }
        IDatabase? Database { get; }
        void SetOptions(string endpoint, string pass);
        void SetConnection(ConfigurationOptions? options);
        void SetDatabase(ConnectionMultiplexer conn);
    }
}
