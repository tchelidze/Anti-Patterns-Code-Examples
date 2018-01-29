using System;
using System.Threading;

namespace Object.Pool.CaseOne
{
    public class DbConnection
    {
        public DbConnection()
        {
            //impersonate long running operation.
            Thread.Sleep(2000);
            Id = new Random().Next();
        }

        public int Id { get; }
    }
}