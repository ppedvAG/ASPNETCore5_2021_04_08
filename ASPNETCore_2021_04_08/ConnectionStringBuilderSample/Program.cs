using System;
using System.Data.SqlClient;

namespace ConnectionStringBuilderSample
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
            builder.DataSource = "SQLExpress";
            builder.InitialCatalog = "TestDb";
            builder.ConnectTimeout = 123;
            builder.IntegratedSecurity = true;
            

            string connectionString = builder.ToString();

            Console.WriteLine(connectionString);
            Console.ReadKey();
        }
    }
}
