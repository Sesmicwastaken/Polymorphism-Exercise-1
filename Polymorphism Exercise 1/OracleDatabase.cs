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
            TimeValidation oracle = new TimeValidation();

            if (!_isOpen)
            {
                _isOpen = true;
                _isClosed = false;
                return "Opening connection to Oracle Database.";
            }
            else if (oracle.TimedOut)
            {
                return "Connection timed out";
            }
            else
            {
                return "Connection to Oracle Database is already Open.";
            }
        }

        public override string CloseConnection()
        {
            TimeValidation oracle = new TimeValidation();
            if (!_isClosed)
            {
                _isClosed = true;
                _isOpen = false;
                return ("Closing connection to Oracle Databse.");
            }
            else if (oracle.TimedOut)
            {
                return "Connection timed out";
            }
            else
            {
                return "Cannot close a database that's not open";
            }
        }
    }
}