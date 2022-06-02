namespace Polymorphism_Exercise_1
{
    public abstract class DbConnection
    {
        public DbConnection(string connectionString)
        {
            Console.WriteLine($"Connected to {connectionString} database.");
            ConnectionString = connectionString;
        }

        public string ConnectionString { get; private set; }

        public static TimeSpan TimeOut
        {
            get => TimeSpan.Parse("0:01:0");
        }

        public abstract string OpenConnection();

        public abstract string CloseConnection();
    }
}