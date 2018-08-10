using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcApp
{
    public static class InMemoryDatabase
    {
        static int visitorCount;
        static string instanceId;

        public static string Intance { get { return instanceId; } }

        static InMemoryDatabase()
        {
            visitorCount = 0;
            instanceId = Guid.NewGuid().ToString();
        }

        public static void IncrementValue()
        {
            visitorCount++;
        }

        public static int GetIntegerValue()
        {
            return visitorCount;
        }
    }
}
