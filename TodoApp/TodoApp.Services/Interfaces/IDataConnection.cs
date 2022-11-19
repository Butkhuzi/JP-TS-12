using Todo.Library;

namespace TodoApp.Services.Interfaces
{
    public interface IDataConnection
    {
        /// <summary>
        /// Gets all users from database
        /// </summary>
        /// <returns>List of users</returns>
        List<UserModel> GetAllUsers();
        /// <summary>
        /// Gets all todos from database
        /// </summary>
        /// <returns>List of todos</returns>
        List<TodoModel> GetAllTodos();
        /// <summary>
        /// Gets all todos for a specifc user.
        /// </summary>
        /// <param name="model">User model</param>
        /// <returns>List of todos</returns>
        List<TodoModel> GetAllTodosPerUser(UserModel model);
        /// <summary>
        /// Logs in user in system.
        /// </summary>
        /// <param name="user">User that tries to log in</param>
        /// <returns>Logged in user</returns>
        UserModel LoginUser(UserModel user);
        /// <summary>
        /// Register user in database
        /// </summary>
        /// <param name="model">New user</param>
        /// <returns>Registered user</returns>
        UserModel RegisterUser(UserModel model);
    }
}
