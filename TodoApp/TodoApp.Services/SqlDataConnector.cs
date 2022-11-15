using Microsoft.Data.SqlClient;
using Todo.Library;
using TodoApp.Services.Interfaces;
using System.Data;

namespace TodoApp.Services
{
    public class SqlDataConnector : IDataConnection
    {
        public List<User> GetAllUsers()
        {
            const string sqlExpression = "sp_allUsers";
            List<User> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        while (reader.Read())
                        {
                            result.Add(new User
                            {
                                UserId = reader.GetInt32(0),
                                FirstName = reader.GetString(1),
                                LastName = reader.GetString(2),
                                FullName = reader.GetString(3),
                                Email = reader.GetString(4)
                            });
                        }
                    }
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }

                return result;
            }

        }
    }
}
