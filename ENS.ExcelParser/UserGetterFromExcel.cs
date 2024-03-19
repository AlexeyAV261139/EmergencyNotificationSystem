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
            var dataTables = GetDataTablesFromExcel();
            return GetUsersFromDataTables(dataTables);
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

        private IEnumerable<User> GetUsersFromDataTables(DataTableCollection dataTables)
        {
            foreach (DataTable dt in dataTables)
            {
                for (int i = 1; i < dt.Rows.Count; i++)
                {
                    var dataRow = dt.Rows[i];
                    string[] columnsNames = GetColumnsNames(dt);

                    var user = GetUserFromRow(dataRow, columnsNames);
                    if (user is null)
                        continue;

                    yield return user;
                }                
            }
        }

        private string[] GetColumnsNames(DataTable dt)
        {


        }

        private User GetUserFromRow(DataRow dataRow, string[] columnsNames)
        {
            var cells = dataRow.ItemArray;

            if (cells[0] is null)
            {
                throw new Exception("В строке не указан пользователь");
            }

            User user = new User()
            {
                Name = cells[0]!.ToString()!
            };
            for (int i = 1; i < cells.Length; i++)
            {
                if (cells[i] is null)
                    continue;
                user.Contacts.Add(new Contact
                {
                    Name = columnsNames[i],
                    Value = cells[i]!.ToString()!
                });
            }
            return user;

        }
    }
}

