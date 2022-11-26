namespace TodoApp.Tests
{
    public class LoginUserShould
    {
        [Fact]
        public async void Return_Logged_In_User_From_Database()
        {
            SqlDataConnector sqlDataConnector = new();

            string argument = "nika.chkhartishvili@gmail.com";

            var expected = await sqlDataConnector.LoginUserAsync(argument);
            var actual = await sqlDataConnector.LoginUserAsync(argument);

            Assert.Equal(expected, actual, new UserEquilityComparer());
        }

        [Fact]
        public async void Throw_Argument_Null_Exception_If_Argument_Is_Null()
        {
            SqlDataConnector sqlDataConnector = new();
            await Assert.ThrowsAsync<ArgumentException>(() => sqlDataConnector.LoginUserAsync(string.Empty));
        }
    }
}
