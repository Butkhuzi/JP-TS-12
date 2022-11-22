using TodoApp.Library;
using TodoApp.Services.Interfaces;

namespace TodoApp.Services
{
    public static class GlobalConfig
    {
        public static string ConnectionString { get; private set; } = @"Server=DESKTOP-ILO1R6I\SQLEXPRESS;Database=jpTs12Todo;Trusted_Connection=True;TrustServerCertificate=True";

        public static IDataConnection? DataConnection { get; private set; }
        public static IDataConnection? ChooseDatabase(DatabaseType type)
        {
            switch (type)
            {
                case DatabaseType.Sql:
                    DataConnection = new SqlDataConnector();
                    break;
            }

            return DataConnection;
        }
    }
}
