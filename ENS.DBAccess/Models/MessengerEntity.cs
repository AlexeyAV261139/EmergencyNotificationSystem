namespace ENS.DBAccess.Models
{
    public class MessengerEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public List<ContactEntity> Contacts { get; set; } = [];
    }
}
