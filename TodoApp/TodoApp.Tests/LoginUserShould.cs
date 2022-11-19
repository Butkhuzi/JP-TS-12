namespace TodoApp.Tests
{
    public class LoginUserShould
    {
        [Fact]
        public void Return_Logged_In_User_From_Database()
        {
            SqlDataConnector sqlDataConnector = new();
            UserModel argument = new()
            {
                UserId = 1,
                FirstName = "ნიკა",
                LastName = "ჩხარტიშვილი",
                FullName = "ნიკა ჩხარტიშვილი",
                Email = "nika.chkhartishvili@gmail.com"
            };

            var expected = sqlDataConnector.LoginUser(argument);
            var actual = sqlDataConnector.LoginUser(argument);

            Assert.Equal(expected, actual, new UserEquilityComparer());
        }

        [Fact]
        public void Throw_Argument_Null_Exception_If_Argument_Is_Null()
        {
            SqlDataConnector sqlDataConnector = new();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.Throws<ArgumentNullException>(() => sqlDataConnector.LoginUser(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }
    }
}
