using LoginForm.Models;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;

namespace LoginForm.Data;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    
    
    private SqliteConnection connectiion;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {

        connectiion ??= InitiializeSqliteConnection();

        optionsBuilder.UseSqlite(connectiion);

        base.OnConfiguring(optionsBuilder);
    }

    private static SqliteConnection InitiializeSqliteConnection()
    {
        var connectionsttring = new SqliteConnectionStringBuilder()
        {
            DataSource = Variablies.StaticVariablies.DataBaseName,
        };
        return new SqliteConnection(connectionsttring.ToString());
            
    }
}