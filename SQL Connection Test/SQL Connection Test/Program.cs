using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Transactions;

namespace SQL_Connection_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Ethan Zajac";
            int age = 21;
            DateTime birthday = new DateTime(1998, 5, 16);

            string connectionString = @"Server=localhost\MSSQLSERVER01;Database=CIS560_PracticeDB;User ID=Ethan;
                                        Integrated Security=SSPI";
            var cnn = new SqlConnection(connectionString);

            var cmd = new SqlCommand("INSERT INTO Test.Person(Name, Age, Birthdate) 
															VALUES(@NAME, @AGE, @BIRTHDATE)", cnn);

            cmd.Parameters.AddWithValue("@NAME", name);
            cmd.Parameters.AddWithValue("@AGE", age);
            cmd.Parameters.AddWithValue("@BIRTHDATE", birthday);

            try
            {
                cnn.Open();
                cmd.ExecuteNonQuery();
                Console.WriteLine("Data added");
                cnn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
