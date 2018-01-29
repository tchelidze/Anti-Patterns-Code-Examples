namespace Object.Pool.CaseOne
{
    public class DbConnectionPool : ObjectPoolBase<DbConnection>
    {
        public DbConnectionPool() : base(() => new DbConnection())
        { }
    }
}