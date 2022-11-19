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
    }
}
