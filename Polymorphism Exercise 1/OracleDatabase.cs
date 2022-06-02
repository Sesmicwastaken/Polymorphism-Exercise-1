namespace Polymorphism_Exercise_1
{
    public class OracleDatabase : DbConnection
    {
        private bool _isOpen;
        private bool _isClosed;

        public OracleDatabase(string OracleConnection) : base(OracleConnection)
        {
        }

        public override string OpenConnection()
        {
            if (!_isOpen)
            {
                _isOpen = true;
                _isClosed = false;
                return "Opening connection to Oracle Database.";
            }
            else
            {
                return "Connection to Oracle Database is already Open.";
            }
        }

        public override string CloseConnection()
        {
            if (!_isClosed)
            {
                _isClosed = true;
                _isOpen = false;
                return ("Closing connection to Oracle Databse.");
            }
            else
            {
                return "Cannot close a database that's not open";
            }
        }
    }
}