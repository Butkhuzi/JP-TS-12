using Microsoft.Data.SqlClient;
using Todo.Library;
using TodoApp.Services.Interfaces;
using System.Data;

namespace TodoApp.Services
{
    public class SqlDataConnector : IDataConnection
    {
        public List<TodoModel> GetAllTodos()
        {
            const string sqlExpression = "sp_allTodos";
            List<TodoModel> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new TodoModel
                            {
                                TodoId = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Description = reader.GetString(2),
                                StartDate = reader.GetDateTime(3),
                                DueDate = reader.GetDateTime(4),
                                Status = reader.GetString(5),
                                Priority = reader.GetString(6),
                                UserId = reader.GetInt32(7)
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
            }

            return result;
        }
        public List<TodoModel> GetAllTodosPerUser(UserModel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            const string sqlExpression = "sp_allTodosPerUser";
            List<TodoModel> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    connection.Open();

                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@userId", model.UserId);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new TodoModel
                            {
                                TodoId = reader.GetInt32(0),
                                Title = reader.GetString(1),
                                Description = reader.GetString(2),
                                StartDate = reader.GetDateTime(3),
                                DueDate = reader.GetDateTime(4),
                                Status = reader.GetString(5),
                                Priority = reader.GetString(6),
                                UserId = reader.GetInt32(7)
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
            }



            return result;
        }
        public List<UserModel> GetAllUsers()
        {
            const string sqlExpression = "sp_allUsers";
            List<UserModel> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.Add(new UserModel
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
        public UserModel LoginUser(UserModel user)
        {
            if (user is null)
            {
                throw new ArgumentNullException(nameof(user));
            }

            const string sqlExpression = @"sp_login";
            UserModel result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression,connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@email", user.Email);

                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            result.UserId = reader.GetInt32(0);
                            result.FirstName = reader.GetString(1);
                            result.LastName = reader.GetString(2);
                            result.FullName = reader.GetString(3);
                            result.Email = reader.GetString(4);
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
            }

            return result;
        }

        public UserModel RegisterUser(UserModel model)
        {
            const string sqlExpression = "sp_registerUser";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@userId", model.UserId);
                    command.Parameters.AddWithValue("@firstName", model.FirstName);
                    command.Parameters.AddWithValue("@lastName", model.LastName);
                    command.Parameters.AddWithValue("@email", model.Email);

                    command.ExecuteNonQuery();

                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    connection.Close();
                }
            }

            return model;
            // TODO -- Write test for this function.
        }
    }
}
