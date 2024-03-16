using ENS.ExcelParser.Interfaces;
using ExcelDataReader;
using System.Data;

namespace ENS.ExcelParser
{
    public class ContactsFromExcelGetter : IContactsGetter
    {
        private readonly string _filePath;

        public ContactsFromExcelGetter(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            _filePath = filePath;
        }

        public DataSet GetContactsAsDataSet()
        {
            return GetDataFromExcelAsDataSet();
        }       

        private DataSet GetDataFromExcelAsDataSet()
        {

            using (var stream = File.Open(_filePath, FileMode.Open, FileAccess.Read))
            {                
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var result = reader.AsDataSet();
                    return result;
                }
            }
        }
    }
}

