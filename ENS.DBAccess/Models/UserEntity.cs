﻿namespace ENS.DBAccess.Models
{
    public class UserEntity
    {
        public Guid Id { get; set; }

        public string FullName { get; set; } = string.Empty;

        public List<ContactEntity> Contacts { get; set; } = [];
    }
}
