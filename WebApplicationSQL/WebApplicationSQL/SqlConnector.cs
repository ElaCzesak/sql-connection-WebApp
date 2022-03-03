using System;
using System.Data;
using System.Data.SqlClient;
using WebApplicationSQL.Models;

namespace WebApplicationSQL
{
    public class SqlConnector
    {
        public List<Car> ReadCarData()
        {
            string connectionString = "Data Source=DESKTOP-FCNEOFV;Initial Catalog=restDB;Integrated Security=SSPI";
            string queryString = "SELECT ID, AutoName FROM dbo.Cars;";

            List<Car> carList = new List<Car>();

            using (var connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    carList.Add(new Car()
                    {
                        ID = reader.GetFieldValue<int>(0),
                        Name = reader.GetFieldValue<string>(1)
                    });
                }
                reader.Close();
            }

            return carList;
        }
    }
}
