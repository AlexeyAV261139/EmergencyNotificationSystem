using ENS.ExcelParser.Interfaces;
using ENS.ExcelParser.Models;
using ExcelDataReader;
using System.Data;

namespace ENS.ExcelParser
{
    public class UserGetterFromExcel : IUserGetter
    {
        private readonly string _filePath;

        public UserGetterFromExcel(string filePath)
        {
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);
            _filePath = filePath;
        }       

        public IEnumerable<User> GetUsers()
        {           
            return GetUsersFromDataTable();
        }       

        private IEnumerable<User> GetUsersFromDataTable()
        {
            var dataTables = GetDataTablesFromExcel();

            foreach(DataTable dt in dataTables)
            {
                foreach(DataRow dataRow in dt.Rows)
                {
                    var cells = dataRow.ItemArray;

                    var columns = dt.Columns;

                    if (cells[0] != null)
                    {
                        User user = new User()
                        {
                            Name = cells[0]!.ToString()!
                        };
                        for (int i = 1; i < cells.Length; i++)
                        {
                            user.Contacts.Add(new Contact
                            {
                                Name = columns[i].ColumnName,
                                Value = cells[i]!.ToString()!
                            });
                        }
                        yield return user;
                    }                    
                }
            }
        }

        private DataTableCollection GetDataTablesFromExcel()
        {
            using (var stream = File.Open(_filePath, FileMode.Open, FileAccess.Read))
            {                
                using (var reader = ExcelReaderFactory.CreateReader(stream))
                {
                    var dataTables = reader.AsDataSet().Tables;
                    return dataTables;
                }
            }
        }
    }
}

