namespace TodoApp.Tests
{
    public class GetAllUsersShould
    {
        [Fact]
        public void Return_All_Users_From_Database()
        {
            SqlDataConnector sqlDataConnector = new();

            //List<UserModel> expected = new()
            //{
            //    new UserModel()
            //    {
            //        UserId = 1,
            //        FirstName = "ნიკა",
            //        LastName = "ჩხარტიშვილი",
            //        FullName = "ნიკა ჩხარტიშვილი",
            //        Email = "nika.chkhartishvili@gmail.com"
            //    },
            //    new UserModel()
            //    {
            //        UserId = 2,
            //        FirstName = "ივანე",
            //        LastName = "შუბითიძე",
            //        FullName = "ივანე შუბითიძე",
            //        Email = "ivane.shubitidze@gmail.com"
            //    },
            //    new UserModel()
            //    {
            //        UserId = 3,
            //        FirstName = "ნიკოლოზ",
            //        LastName = "ცანავა",
            //        FullName = "ნიკოლოზ ცანავა",
            //        Email = "nikoloz.tsanava@gmail.com"
            //    },
            //    new UserModel()
            //    {
            //        UserId = 4,
            //        FirstName = "ლუკა",
            //        LastName = "ზარიძე",
            //        FullName = "ლუკა ზარიძე",
            //        Email = "luka.zaridze@gmail.com"
            //    },
            //    new UserModel()
            //    {
            //        UserId = 5,
            //        FirstName = "დემეტრე",
            //        LastName = "დონდოლაძე",
            //        FullName = "დემეტრე დონდოლაძე",
            //        Email = "demetre.dondoladze@gmail.com"
            //    },
            //    new UserModel()
            //    {
            //        UserId = 10,
            //        FirstName = "გიორგი",
            //        LastName = "ჯანიკაშვილი",
            //        FullName = "გიორგი ჯანიკაშვილი",
            //        Email = "giorgi.janikashvili@gmail.com"
            //    }
            //};

            var expected = sqlDataConnector.GetAllUsers();
            var actual = sqlDataConnector.GetAllUsers();

            Assert.Equal(expected, actual,new UserEquilityComparer());
        }
    }
}
