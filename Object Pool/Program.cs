using System;
using Object.Pool.CaseOne;

namespace Object_Pool
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var dbConnectionPool = new DbConnectionPool();
            var connection1 = dbConnectionPool.Acquire();
            var connection2 = dbConnectionPool.Acquire();
            var connection3 = dbConnectionPool.Acquire();
            dbConnectionPool.Release(connection1);
            var connection4 = dbConnectionPool.Acquire();

            Console.WriteLine(
                $"Id of connection1 {connection1.Id} shoud be equal to id of connection4 {connection4.Id}");
        }
    }
}