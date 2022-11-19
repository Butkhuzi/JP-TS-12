namespace TodoApp.Services
{
    public static class GlobalConfig
    {
        public static string ConnectionString { get; private set; } = @"Server=DESKTOP-ILO1R6I\SQLEXPRESS;Database=jpTs12Todo;Trusted_Connection=True;TrustServerCertificate=True";
    }
}
