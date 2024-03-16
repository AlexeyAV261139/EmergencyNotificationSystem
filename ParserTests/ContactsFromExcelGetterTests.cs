using ENS.ExcelParser;

namespace ParserTests
{
    public class ContactsFromExcelGetterTests
    {
        const string ExcelFilePath = @"C:\Users\User\Desktop\programming\My programs\EmergencyNotificationSystem\TestFIle.xlsx";

        [Fact]
        public void DataIsNotNull()
        {
            var contactsGetter = new ContactsFromExcelGetter(ExcelFilePath);

            var dbSet = contactsGetter.GetContactsAsDataSet();

            Assert.NotNull(dbSet);
        }


        [Fact]
        public void CorrectCuntColums()
        {
            var contactsGetter = new ContactsFromExcelGetter(ExcelFilePath);

            var dbSet = contactsGetter.GetContactsAsDataSet();

        }
    }
}