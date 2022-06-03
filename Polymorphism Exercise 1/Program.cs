namespace Polymorphism_Exercise_1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Timer TimeMesaurement = new Timer();

            Console.WriteLine("Provide a connection string.(\"Oracle\" for connecting to Oracle databse and \"SQL\" for connecting to SQL databse.)");
            Console.Write("Input: ");
            string input = Console.ReadLine().Trim().ToLower();

            DbSwitch @switch = new DbSwitch();
            @switch.Switch(input);

            if (@switch.IsSQL)
            {
                SQLDatabse sqlDb = new SQLDatabse(input);
                TimeMesaurement.Start();
                while (!TimeMesaurement.TimedOut)
                {
                    Console.WriteLine("Type \"Open\" for opening the connection or \"Close\" for closing the cnnection with the Database.");
                    string connectionState = Console.ReadLine().Trim().ToLower();

                    if (connectionState == "open")
                    {
                        Console.WriteLine(sqlDb.OpenConnection());
                        TimeMesaurement.End();
                        TimeMesaurement.IsValid();
                    }
                    else if (connectionState == "close")
                    {
                        Console.WriteLine(sqlDb.CloseConnection());
                        TimeMesaurement.End();
                        TimeMesaurement.IsValid();
                    }
                    else
                    {
                        throw new ArgumentException("Invalid Input.");
                    }
                }
            }
            else if (@switch.IsOracle)
            {
                OracleDatabase oracle = new OracleDatabase(input);
                TimeMesaurement.Start();

                while (!TimeMesaurement.TimedOut)
                {
                    Console.WriteLine("Type \"Open\" for opening the connection or \"Close\" for closing the cnnection with the Database.");
                    string connectionState2 = Console.ReadLine().Trim().ToLower();

                    if (connectionState2 == "open")
                    {
                        Console.WriteLine(oracle.OpenConnection());
                        TimeMesaurement.End();
                        TimeMesaurement.IsValid();
                    }
                    else if (connectionState2 == "close")
                    {
                        Console.WriteLine(oracle.CloseConnection());
                        TimeMesaurement.End();
                        TimeMesaurement.IsValid();
                    }
                    else
                    {
                        throw new ArgumentException("Invalid Input.");
                    }
                }
            }

            Console.WriteLine("\nError: Connection Timed out");
            return;
        }
    }
}