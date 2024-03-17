namespace ENS.DBAccess.Models
{
    public class ContactEntity
    {
        public Guid Id { get; set; }

        public string Value { get; set;} = string.Empty;

        public Guid MessengerId { get; set; }

        public MessengerEntity? Messenger { get; set; }

        public Guid UserId { get; set; }

        public UserEntity? User { get; set; }


    }
}
