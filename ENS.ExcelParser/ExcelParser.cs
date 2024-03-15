using ENS.ExcelParser.Interfaces;
using ENS.ExcelParser.Models;
using ExcelDataReader;

namespace ENS.ExcelParser
{
    public class ExcelParser : IDataGetterFromFile
    {
        private readonly string _filePath;

        public ExcelParser(string filePath)
        {
            _filePath = filePath;
        }

        public IEnumerable<T> GetData<T>()
        {
            throw new NotImplementedException();
        }

        private IEnumerable<User> ReadUsersFromExcel()
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
                        // Choose one of either 1 or 2:

                        // 1. Use the reader methods
                        do
                        {
                            while (reader.Read())
                            {
                                reader.GetString(0);
                            }
                        } while (reader.NextResult());


                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Ошибка получения данных из xls файла");
            }
        }
    }
}
