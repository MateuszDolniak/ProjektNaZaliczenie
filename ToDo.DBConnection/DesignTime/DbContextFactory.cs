using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using ToDo.DBConnection.DatabaseAccess;

namespace ToDo.DBConnection.DesignTime
{
    [UsedImplicitly]
    public class DbContextFactory : IDesignTimeDbContextFactory<ServerContext>
    {
        public ServerContext CreateDbContext(string[] args)
        {
            return new ServerContext(
                new DbContextOptionsBuilder<ServerContext>()
                    .UseSqlServer("Server=(local);Database=ToDoDB;Integrated Security=true;")
                    .Options);
        }
    }
}
