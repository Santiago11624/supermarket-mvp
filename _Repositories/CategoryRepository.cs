using Supermarket_mvp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Supermarket_mvp._Repositories
{
    internal class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void Add(CategoryModel category)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("INSERT INTO Category (Category_Name, Category_Observation) VALUES (@name, @obs)", connection))
            {
                
                command.Connection = connection;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = category.Name;
                command.Parameters.Add("@obs", SqlDbType.NVarChar).Value = category.Observation;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("DELETE FROM Category WHERE Category_Id = @id", connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = id;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public void Edit(CategoryModel category)
        {
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("UPDATE Category SET Category_Name=@name, Category_Observation=@obs WHERE Category_Id=@id", connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = category.Id;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = category.Name;
                command.Parameters.Add("@obs", SqlDbType.NVarChar).Value = category.Observation;
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            var categoryList = new List<CategoryModel>();
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand(SELECT * FROM Category ORDER BY Category_Id DESC", connection))
            {
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new CategoryModel
                        {
                            Id = (int)reader["Category_Id"],
                            Name = reader["Category_Name"].ToString(),
                            Observation = reader["Category_Observation"].ToString()
                        };
                        categoryList.Add(category);
                    }
                }
            }
            return categoryList;
        }

        public IEnumerable<CategoryModel> GetByValue(string value)
        {
            var categoryList = new List<CategoryModel>();
            int categoryId = int.TryParse(value, out _) ? Convert.ToInt32(value) : 0;
            using (var connection = new SqlConnection(connectionString))
            using (var command = new SqlCommand("SELECT * FROM Category WHERE Category_Id=@id OR Category_Name LIKE @name + '%'", connection))
            {
                command.Parameters.Add("@id", SqlDbType.Int).Value = categoryId;
                command.Parameters.Add("@name", SqlDbType.NVarChar).Value = value;
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var category = new CategoryModel
                        {
                            Id = (int)reader["Category_Id"],
                            Name = reader["Category_Name"].ToString(),
                            Observation = reader["Category_Observation"].ToString()
                        };
                        categoryList.Add(category);
                    }
                }
            }
            return categoryList;
        }
    }
}
