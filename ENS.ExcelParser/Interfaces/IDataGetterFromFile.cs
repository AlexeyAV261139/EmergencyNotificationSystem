namespace ENS.ExcelParser.Interfaces
{
    public interface IDataGetterFromFile
    {
        public IEnumerable<T> GetData<T>();
    }
}
