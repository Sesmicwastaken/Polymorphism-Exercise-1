namespace Polymorphism_Exercise_1
{
    public class DbSwitch
    {
        public bool IsSQL { get; private set; }
        public bool IsOracle { get; private set; }

        public void Switch(string dbType)
        {
            if (dbType == "sql")
            {
                IsSQL = true;
            }
            else if (dbType == "oracle")
            {
                IsOracle = true;
            }
            else if (InputValidation.IsValid(dbType) == true)
            {
                throw new ArgumentNullException(dbType, "Connection string cannot be null");
            }
            else
            {
                throw new ArgumentException("Connection string is not valid");
            }
        }
    }
}