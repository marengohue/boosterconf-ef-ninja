﻿namespace BoosterConf.Ef.Ninja.TaskA.Models
{
    public class CustomerAddress
    {
        public Guid Id { get; set; }
        
        public required string Street { get; set; } 

        public required string City { get; set; }

        public required string PostalCode { get; set; }

        public required string Country { get; set; }
    }
}
