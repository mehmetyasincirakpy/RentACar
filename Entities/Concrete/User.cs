﻿using Core.Entities;

namespace Entities.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string eMail { get; set; }
        public byte PasswordHash { get; set; }
        public byte PasswordSalt { get; set; }
        public bool Status { get; set; }
    }
}
