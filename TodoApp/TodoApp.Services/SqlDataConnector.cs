using Microsoft.Data.SqlClient;
using Todo.Library;
using TodoApp.Services.Interfaces;
using System.Data;

namespace TodoApp.Services
{
    public class SqlDataConnector : IDataConnection
    {
        public async Task<TodoModel> EditTodoAsync(TodoModel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            const string sqlExpression = "sp_editTodo";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@title",model.Title);
                    command.Parameters.AddWithValue("@description",model.Description);
                    command.Parameters.AddWithValue("@startDate",model.StartDate);
                    command.Parameters.AddWithValue("@dueDate",model.DueDate);
                    command.Parameters.AddWithValue("@status",model.Status);
                    command.Parameters.AddWithValue("@prioirity",model.Priority);
                    command.Parameters.AddWithValue("@todoId", model.TodoId);

                    await command.ExecuteNonQueryAsync();
                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }

            return model;
        }
        public async Task<List<TodoModel>> GetAllTodosAsync()
        {
            const string sqlExpression = "sp_allTodos";
            List<TodoModel> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
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
                    await connection.CloseAsync();
                }
            }

            return result;
        }
        public async Task<List<TodoModel>> GetAllTodosPerUserAsync(UserModel model)
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
                    await connection.OpenAsync();

                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@userId", model.UserId);

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
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
                    await connection.CloseAsync();
                }
            }



            return result;
        }
        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            const string sqlExpression = "sp_allUsers";
            List<UserModel> result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
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
                    await connection.CloseAsync();
                }

                return result;
            }

        }
        public async Task<UserModel> LoginUserAsync(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
            {
                throw new ArgumentException($"'{nameof(email)}' cannot be null or whitespace.", nameof(email));
            }

            const string sqlExpression = @"sp_login";
            UserModel result = new();

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression,connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@email", email);

                    SqlDataReader reader = await command.ExecuteReaderAsync();

                    if (reader.HasRows)
                    {
                        while (await reader.ReadAsync())
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
                    await connection.CloseAsync();
                }
            }

            return result;
        }
        public async Task<UserModel> RegisterUserAsync(UserModel model)
        {
            if (model is null)
            {
                throw new ArgumentNullException(nameof(model));
            }

            const string sqlExpression = "sp_registerUser";

            using (SqlConnection connection = new(GlobalConfig.ConnectionString))
            {
                try
                {
                    await connection.OpenAsync();
                    SqlCommand command = new(sqlExpression, connection);
                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("@firstName", model.FirstName);
                    command.Parameters.AddWithValue("@lastName", model.LastName);
                    command.Parameters.AddWithValue("@email", model.Email);

                    await command.ExecuteNonQueryAsync();

                }
                catch (SqlException)
                {
                    throw;
                }
                finally
                {
                    await connection.CloseAsync();
                }
            }
            return model;
        }
    }
}
