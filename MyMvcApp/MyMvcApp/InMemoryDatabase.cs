using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMvcApp
{
    public static class InMemoryDatabase
    {
        static int visitorCount;

        static InMemoryDatabase()
        {
            visitorCount = 0;
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
