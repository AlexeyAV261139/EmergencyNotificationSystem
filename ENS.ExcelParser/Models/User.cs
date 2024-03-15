namespace ENS.ExcelParser.Models
{
    public class User
    {
        public string Name { get; set; } = string.Empty;

        public List<Contact> Contacts { get; set; } = [];

    }
}
