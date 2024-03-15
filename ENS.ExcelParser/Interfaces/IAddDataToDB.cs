namespace ENS.ExcelParser.Interfaces
{
    public interface IAddDataToDB
    {
        public void Add<T>(T entity);
    }
}
