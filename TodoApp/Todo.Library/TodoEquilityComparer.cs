using System.Diagnostics.CodeAnalysis;
using Todo.Library;

namespace TodoApp.Library
{
    public class TodoEquilityComparer : IEqualityComparer<TodoModel>
    {
        public bool Equals(TodoModel x, TodoModel y)
        {
            return x.Title == y.Title && x.Description == y.Description;
        }

        public int GetHashCode([DisallowNull] TodoModel obj)
        {
            return obj.Description.Length;
        }
    }
}
