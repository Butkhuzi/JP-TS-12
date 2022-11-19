namespace TodoApp.Tests
{
    public class GetAllTodosPerUserShould
    {
        [Fact]
        public void Return_All_Todos_From_Database_For_Specific_User()
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

            var expected = sqlDataConnector.GetAllTodosPerUser(argument);
            var actual = sqlDataConnector.GetAllTodosPerUser(argument);

            Assert.Equal(expected, actual, new TodoEquilityComparer());
        }

        [Fact]
        public void Throw_Argument_Null_Exception_If_Argument_Is_Null()
        {
            SqlDataConnector sqlDataConnector = new();
#pragma warning disable CS8625 // Cannot convert null literal to non-nullable reference type.
            Assert.Throws<ArgumentNullException>(() => sqlDataConnector.GetAllTodosPerUser(null));
#pragma warning restore CS8625 // Cannot convert null literal to non-nullable reference type.
        }


    }
}
