namespace TodoApp.Tests
{
    public class GetAllTodosPerUserShould
    {
        [Fact]
        public async void Return_All_Todos_From_Database_For_Specific_User()
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

            var expected = await sqlDataConnector.GetAllTodosPerUserAsync(argument);
            var actual = await sqlDataConnector.GetAllTodosPerUserAsync(argument);

            Assert.Equal(expected, actual, new TodoEquilityComparer());
        }

        [Fact]
        public async Task Throw_Argument_Null_Exception_If_Argument_Is_Null()
        {
            SqlDataConnector sqlDataConnector = new();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            await Assert.ThrowsAsync<ArgumentNullException>(() => sqlDataConnector.GetAllTodosPerUserAsync(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }
    }
}
