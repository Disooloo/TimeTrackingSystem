using System.Data.Entity;
using System.Data.SQLite;
using TimeTrackingSystem.Models;

namespace TimeTrackingSystem
{
    public class UserDbContext : DbContext
    {
            public UserDbContext() : base("MyConnectionString") { }

            public DbSet<User> Users { get; set; }

            private static SQLiteConnection CreateConnection()
        {
            // Путь к файлу базы данных SQLite
            string databasePath = "Assets/db/TimeTrackingSystem.db";

            // Строка подключения к базе данных SQLite
            string connectionString = $"Data Source={databasePath};Version=3;";

            // Создание подключения к базе данных SQLite
            return new SQLiteConnection(connectionString);
        }
    }
}
