namespace Polymorphism_Exercise_1
{
    public class SQLDatabse : DbConnection
    {
        private bool _isOpen;
        private bool _isClosed;

        public SQLDatabse(string SQLConnection) : base(SQLConnection)
        {
        }

        public override string OpenConnection()
        {
            Timer sql = new Timer();
            if (!_isOpen)
            {
                _isOpen = true;
                _isClosed = false;
                return ("Opening connection to SQL Database.");
            }
            else
            {
                return ("Connection to SQL Database is already Open.");
            }
        }

        public override string CloseConnection()
        {
            Timer sql = new Timer();

            if (!_isClosed)
            {
                _isClosed = true;
                _isOpen = false;
                return ("Closing connection to SQL Databse.");
            }
            else
            {
                return "Cannot close a database that's not open";
            }
        }
    }
}