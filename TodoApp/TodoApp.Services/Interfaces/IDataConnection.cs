using Todo.Library;

namespace TodoApp.Services.Interfaces
{
    public interface IDataConnection
    {
        /// <summary>
        /// Gets all users from database
        /// </summary>
        /// <returns>List of users</returns>
        Task<List<UserModel>> GetAllUsersAsync();
        /// <summary>
        /// Gets all todos from database
        /// </summary>
        /// <returns>List of todos</returns>
        Task<List<TodoModel>> GetAllTodosAsync();
        /// <summary>
        /// Gets all todos for a specifc user.
        /// </summary>
        /// <param name="model">User model</param>
        /// <returns>List of todos</returns>
        Task<List<TodoModel>> GetAllTodosPerUserAsync(UserModel model);
        /// <summary>
        /// Logs in user in system.
        /// </summary>
        /// <param name="user">User that tries to log in</param>
        /// <returns>Logged in user</returns>
        Task<UserModel> LoginUserAsync(string email);
        /// <summary>
        /// Register user in database
        /// </summary>
        /// <param name="model">New user</param>
        /// <returns>Registered user</returns>
        Task<UserModel> RegisterUserAsync(UserModel model);
        /// <summary>
        /// Edit todo in database
        /// </summary>
        /// <param name="model">Todo to edit</param>
        /// <returns>Edited todo</returns>
        Task<TodoModel> EditTodoAsync(TodoModel model);
        /// <summary>
        /// Adds new todo in database.
        /// </summary>
        /// <param name="model">New todo</param>
        /// <returns>Added todo</returns>
        Task<TodoModel> AddTodoAsync(TodoModel model);
        /// <summary>
        /// Delete todo from database
        /// </summary>
        /// <param name="model">Todo to delete</param>
        /// <returns>Deleted todo</returns>
        Task<TodoModel> DeleteTodoAsync(TodoModel model);
    }
}
