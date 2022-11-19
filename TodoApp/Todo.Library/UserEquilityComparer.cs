using System.Diagnostics.CodeAnalysis;
using Todo.Library;

namespace TodoApp.Library
{
    public class UserEquilityComparer : IEqualityComparer<UserModel>
    {
        public bool Equals(UserModel x, UserModel y)
        {
            return x.Email == y.Email;
        }

        public int GetHashCode([DisallowNull] UserModel obj)
        {
            return obj.FullName.Length;
        }
    }
}
