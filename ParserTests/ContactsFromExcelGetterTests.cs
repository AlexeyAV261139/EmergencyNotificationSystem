using ENS.ExcelParser;
using ENS.ExcelParser.Models;

namespace ParserTests
{
    public class ContactsFromExcelGetterTests
    {
        const string ExcelFilePath = @"C:\Users\User\Desktop\programming\My programs\EmergencyNotificationSystem\TestFIle.xlsx";


        [Fact]
        public void UserGetterTest()
        {
            var contactsGetter = new UserGetterFromExcel(ExcelFilePath);
            var expectedUsers = new User[]
            {
                new User 
                { 
                    Name = "Соколов Алексей Владимирович",
                    Contacts = new List<Contact>
                    {
                        new Contact { Name = "Телеграмм", Value = "@SokolovAV03"},
                        new Contact { Name = "Вк", Value = "https://vk.com/sokolov_smol"},
                        new Contact { Name = "телефон", Value = "89516912858"}
                    }                    
                },
                new User
                {
                    Name = "Кацкель Мария Сергеевна",
                    Contacts = new List<Contact>
                    {
                        new Contact { Name = "Телеграмм", Value = "@SokolovAV03"},
                        new Contact { Name = "Вк", Value = "https://vk.com/sokolov_smol"},
                        new Contact { Name = "телефон", Value = "89516912858"}
                    }
                }
            };


            var users = contactsGetter.GetUsers().ToArray();

            Assert.Equal(expectedUsers, users);

        }
    }
}