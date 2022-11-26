namespace TodoApp.Tests
{
    public class LoginUserShould
    {
        [Fact]
        public async void Return_Logged_In_User_From_Database()
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

            var expected = await sqlDataConnector.LoginUserAsync(argument);
            var actual = await sqlDataConnector.LoginUserAsync(argument);

            Assert.Equal(expected, actual, new UserEquilityComparer());
        }

        [Fact]
        public async void Throw_Argument_Null_Exception_If_Argument_Is_Null()
        {
            SqlDataConnector sqlDataConnector = new();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            await Assert.ThrowsAsync<ArgumentNullException>(() => sqlDataConnector.LoginUserAsync(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }
    }
}
