using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace To_Read_Finnish_Customers_From_Database_table
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=POUTAKONE\\SQLEXPRESS2021;Initial Catalog=Northwind;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

            //To open a connection.
            try
            {
                connection.Open();
                SqlDataReader reader = null; //The reader is a data reader object. The selected statemen is just a query on a database.
                SqlCommand command = new SqlCommand("select * from Customers ", connection); //The command that is going to be used.

                //To feed all the data from the command into the reader object.
                reader = command.ExecuteReader();

                //To iterrate over the data.
                while (reader.Read())
                {
                    //Pull the data from the reader.
                    Console.WriteLine(String.Format("",reader));
                }
            }
            //select * from Customers where Country = 'Finland
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
