namespace TodoApp.Tests
{
    public class RegisterUserShould
    {
        [Fact]
        public void Register_New_User_In_Database()
        {
            SqlDataConnector sqlDataConnector = new();

            UserModel expectedNewUser = new()
            {
                FirstName = "გიორგი",
                LastName = "ფირანიშვილი",
                Email = "giorgi.firanishvili@gmail.com"
            };

            var actual = sqlDataConnector.RegisterUser(expectedNewUser);

            Assert.Equal(expectedNewUser, actual, new UserEquilityComparer());
        }

        [Fact]
        public void Throw_Argument_Null_Exception_If_Argument_Is_Null()
        {
            SqlDataConnector sqlDataConnector = new();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.Throws<ArgumentNullException>(() => sqlDataConnector.RegisterUser(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

    }
}
