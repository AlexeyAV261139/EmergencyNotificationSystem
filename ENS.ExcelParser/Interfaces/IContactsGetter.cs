using ENS.ExcelParser.Models;
using System.Data;

namespace ENS.ExcelParser.Interfaces
{
    public interface IContactsGetter
    {
        public IEnumerable<Contact> GetContacts();
    }
}
