using ENS.ExcelParser.Models;

namespace ENS.ExcelParser.Interfaces
{
    public interface IUserGetter
    {
        public IEnumerable<User> GetUsers();

    }

}
