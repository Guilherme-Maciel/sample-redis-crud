using sample_redis_crud.Redis.Interface;
using StackExchange.Redis;

namespace sample_redis_crud.Redis.Models
{
    public class RedisClient : IRedisClient
    {
        public RedisClient(string url, string port, string pass)
        {
            Url = url;
            Port = port;
            Pass = pass;
            SetOptions($"{Url}:{Port}", Pass);
            SetConnection(Options);
            SetDatabase(Connection);
        }
        public string? Url { get; private set; }
        public string? Port { get; private set; }
        public string? Pass { get; private set; }
        public ConfigurationOptions? Options { get; private set; }
        public ConnectionMultiplexer? Connection { get; private set; }
        public IDatabase? Database { get; private set; }

        public override string ToString()
        {
            return $"{Url}:{Port}";
        }

        public void SetOptions(string endpoint, string pass)
        {
            Options = new ConfigurationOptions
            {
                EndPoints = { endpoint },
                Password = pass,
                AbortOnConnectFail = false
            };
        }

        public void SetConnection(ConfigurationOptions? options)
        {
            if (options != null)
                Connection = ConnectionMultiplexer.Connect(options);
        }

        public void SetDatabase(ConnectionMultiplexer? conn)
        {
            if (conn != null)
                Database = conn.GetDatabase();
        }

    }
}
