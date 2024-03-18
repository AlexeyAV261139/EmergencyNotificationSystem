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
                    Name = "������� ������� ������������",
                    Contacts = new List<Contact>
                    {
                        new Contact { Name = "���������", Value = "@SokolovAV03"},
                        new Contact { Name = "��", Value = "https://vk.com/sokolov_smol"},
                        new Contact { Name = "�������", Value = "89516912858"}
                    }                    
                },
                new User
                {
                    Name = "������� ����� ���������",
                    Contacts = new List<Contact>
                    {
                        new Contact { Name = "���������", Value = "@SokolovAV03"},
                        new Contact { Name = "��", Value = "https://vk.com/sokolov_smol"},
                        new Contact { Name = "�������", Value = "89516912858"}
                    }
                }
            };


            var users = contactsGetter.GetUsers().ToArray();

            Assert.Equal(expectedUsers, users);

        }
    }
}