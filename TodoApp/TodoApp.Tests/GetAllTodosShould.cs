namespace TodoApp.Tests
{
    public class GetAllTodosShould
    {
        [Fact]
        public void Return_All_Todos_From_Database()
        {
            SqlDataConnector sqlDataConnector = new();

            var expected = sqlDataConnector.GetAllTodos();
            var actual = sqlDataConnector.GetAllTodos();

            Assert.Equal(expected, actual, new TodoEquilityComparer());
        }
    }
}
