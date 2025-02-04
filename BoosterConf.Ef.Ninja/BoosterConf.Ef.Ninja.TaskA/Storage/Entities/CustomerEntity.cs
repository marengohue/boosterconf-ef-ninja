﻿namespace BoosterConf.Ef.Ninja.TaskA.Storage.Entities
{
    public class CustomerEntity : IEntity
    {
        public int Id { get; set; }
        public Guid ExternalId { get; set; }
        public required string FirstName { get; set; }
        public required string LastName { get; set; }
        public required string Email { get; set; }
        public required string PhoneNumber { get; set; }
        public CustomerAddressEntity? Address { get; set; }
        public ICollection<CoverEntity>? Covers { get; set; }
    }
}
