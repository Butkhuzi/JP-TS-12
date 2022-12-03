namespace TodoApp.Tests
{
    public class EditTodoAsyncShould
    {
        [Fact]
        public async void Edit_Todo_In_Database()
        {
            SqlDataConnector connector = new();

            TodoModel expected = new()
            {
                TodoId = 4,
                Title = "ლექციის ჩატარება4",
                Description = "ჩასატარებელია ლექცია და ასახსნელია ახალი თემა",
                StartDate = DateTime.Parse("2022-11-15 17:58:55.070"),
                DueDate = DateTime.Parse("2022-11-15 17:58:55.070"),
                Status = "მიმდინარე",
                Priority = "მაღალი",
                UserId = 1
            };

            var actual = await connector.EditTodoAsync(expected);

            Assert.Equal(expected, actual, new TodoEquilityComparer());
        }

        [Fact]
        public async void Throw_Argument_Null_Exception_If_Argument_Is_Null()
        {
            SqlDataConnector sqlDataConnector = new();
            await Assert.ThrowsAsync<ArgumentNullException>(() => sqlDataConnector.EditTodoAsync(null));
        }

    }
}
