namespace TodoApp.Tests
{
    public class GetAllTodosShould
    {
        [Fact]
        public async void Return_All_Todos_From_Database()
        {
            SqlDataConnector sqlDataConnector = new();

            var expected = await sqlDataConnector.GetAllTodosAsync();
            var actual = await sqlDataConnector.GetAllTodosAsync();

            Assert.Equal(expected, actual, new TodoEquilityComparer());
        }
    }
}
