using ENS.ExcelParser;
using ENS.ExcelParser.Models;

namespace ParserTests
{
    public class ExcelParserTests
    {
        const string ExcelFilePath = @"C:\Users\User\Desktop\programming\My programs\EmergencyNotificationSystem\TestFIle.xlsx";

        [Fact]
        public void UsersAreNotNull()
        {
            var exParser = new ExcelParser(ExcelFilePath);


            var users = exParser.GetUsers();
            
            Assert.NotNull(users);
        }

         
    }
}