using ENS.ExcelParser.Interfaces;
using ENS.ExcelParser.Models;
using ExcelDataReader;
using System.Data;

namespace ENS.ExcelParser
{
    public partial class ExcelParser : IDataGetterFromFile
    {
        private readonly string _filePath;

        public ExcelParser(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            _filePath = filePath;
        }

        public DataSet GetData()
        {
            return GetDataFromExcelAsDataSet();
        }

        private DataSet GetDataFromExcelAsDataSet()
        {
            try
            {
                using (var stream = File.Open(_filePath, FileMode.Open, FileAccess.Read))
                {
                    // Auto-detect format, supports:
                    // - Binary Excel files (2.0-2003 format; *.xls)
                    // - OpenXml Excel files (2007 format; *.xlsx, *.xlsb)
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        var result = reader.AsDataSet();
                        return result;
                    }
                }
            }
            catch 
            {
                throw new Exception("Ошибка получения данных из xls файла");
            }
        }
    }
}
