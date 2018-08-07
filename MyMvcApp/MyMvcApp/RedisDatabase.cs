using StackExchange.Redis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcApp
{
    public static class RedisDatabase
    {
        static ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("localhost");

        public static void IncrementValue(string key)
        {
            var db = redis.GetDatabase();
            db.StringIncrement(key);
        }

        public static int GetIntegerValue(string key)
        {
            var db = redis.GetDatabase();
            return (int)db.StringGet(key);
        }
    }
}
