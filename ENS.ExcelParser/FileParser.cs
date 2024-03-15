using ENS.ExcelParser.Interfaces;
using ENS.ExcelParser.Models;

namespace ENS.ExcelParser
{
    public class FileParser
    {
        private IDataGetterFromFile _dataGetter;
        private IAddDataToDB _dbAdder;

        public FileParser(IDataGetterFromFile reader, IAddDataToDB dBAdd)
        {
            _dataGetter = reader;
            _dbAdder = dBAdd;
        }

        public async Task Start()
        {
            var ds = _dataGetter.GetData();

            var users = _dataGetter.GetUsers();
            foreach (var user in users)
            {
                 _dbAdder.Add(user);
            }
        }
    }
}
