using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Supermarket_mvp.Models;
using Microsoft.Data.SqlClient;
using System.Data;
using Microsoft.Data;

namespace Supermarket_mvp._Repositories
{
    internal class CustomersRepository : BaseRepository, ICustomersRepository
    {
        public CustomersRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CustomersModel customer)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Edit(CustomersModel customer)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomersModel> GetAll()
        {
            var customersList = new List<CustomersModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customer ORDER BY Document_Number DESC";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomersModel();
                        customerModel.Document_Number = (int)reader["Customers_Document_Number"];
                        customerModel.Name = (string)reader["Customers_Name"];
                        customerModel.Last_Name = (string)reader["Customers_Last_Name"].ToString();
                        customerModel.Address = (string)reader["Customers_Address"].ToString();
                        customerModel.Phone_Number = (string)reader["Customers_Phone"].ToString();
                        customerModel.Email = (string)reader["Customers_Email"].ToString();

                    }
                }

            }
            return customersList;
        }

        public CustomersModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CustomersModel> GetByValue(string value)
        {
            var customersList = new List<CustomersModel>();
            int customerId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            string customerName = value;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Customers WHERE Customers_Document_Number=@id OR Customers_Name=@name";
                command.Parameters.Add("@id", SqlDbType.Int).Value = customerId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = customerName;
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var customerModel = new CustomersModel();
                        customerModel.Document_Number = (int)reader["Customers_Document_Number"];
                        customerModel.Name = (string)reader["Customers_Name"];
                        customerModel.Last_Name = (string)reader["Customers_Last_Name"].ToString();
                        customerModel.Address = (string)reader["Customers_Address"].ToString();
                        customerModel.Phone_Number = (string)reader["Customers_Phone"].ToString();
                        customerModel.Email = (string)reader["Customers_Email"].ToString();
                    }
                }
            }
            return customersList;
        }
    }
}
