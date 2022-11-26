namespace TodoApp.Tests
{
    public class RegisterUserShould
    {
        [Fact]
        public async void Register_New_User_In_Database()
        {
            SqlDataConnector sqlDataConnector = new();

            UserModel expectedNewUser = new()
            {
                FirstName = "გიორგი",
                LastName = "ფირანიშვილი",
                Email = "giorgi.firanishvili@gmail.com"
            };

            var actual = await sqlDataConnector.RegisterUserAsync(expectedNewUser);

            Assert.Equal(expectedNewUser, actual, new UserEquilityComparer());
        }

        [Fact]
        public async void Throw_Argument_Null_Exception_If_Argument_Is_Null()
        {
            SqlDataConnector sqlDataConnector = new();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            await Assert.ThrowsAsync<ArgumentNullException>(() => sqlDataConnector.RegisterUserAsync(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }

    }
}
