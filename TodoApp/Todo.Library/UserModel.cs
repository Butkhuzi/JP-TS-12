using TodoApp.Library;

namespace Todo.Library
{
    public class UserModel
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }

        public override int GetHashCode()
        {
            return new UserEquilityComparer().GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return new UserEquilityComparer().Equals(obj);
        }
    }
}
