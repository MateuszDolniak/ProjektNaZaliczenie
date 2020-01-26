using Microsoft.EntityFrameworkCore;
using Ninject.Modules;
using ToDo.DBConnection.DatabaseAccess;

namespace ToDo.DBConnection
{
    public class DbModule : NinjectModule
    {
        private readonly string _connectionString;

        public DbModule(string connectionString)
        {
            _connectionString = connectionString;

        }

        public override void Load()
        {
            Bind<ServerContext>().ToSelf();
            Bind<DbContextOptions>().ToConstant(new DbContextOptionsBuilder().UseSqlServer(_connectionString).Options);
        }
    }
}
