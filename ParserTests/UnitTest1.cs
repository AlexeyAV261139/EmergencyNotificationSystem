using ENS.ExcelParser;

namespace ParserTests
{
    public class ExcelParserTests
    {
        const string ExcelFilePath = @"C:\Users\User\Desktop\programming\My programs\EmergencyNotificationSystem\TestFIle.xlsx";

        [Fact]
        public void Test1()
        {
            var exParser = new ExcelParser(ExcelFilePath);


            
        }
    }
}