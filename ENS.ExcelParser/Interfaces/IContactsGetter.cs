using System.Data;

namespace ENS.ExcelParser.Interfaces
{
    public interface IContactsGetter
    {
        public DataSet GetContactsAsDataSet();
    }

}
