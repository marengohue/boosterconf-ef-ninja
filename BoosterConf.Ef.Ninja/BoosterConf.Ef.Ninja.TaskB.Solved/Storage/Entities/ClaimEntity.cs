﻿using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoosterConf.Ef.Ninja.TaskB.Solved.Storage.Entities
{
    public class ClaimEntity : IEntity
    {
        public int Id { get; set; }
        public required Guid ExternalId { get; set; }
        [StringLength(200)]
        public required string Description { get; set; }
        public required DateTimeOffset Date { get; set; }
        public required ClaimStatusEntity Status { get; set; }
        [Precision(14, 4)]
        public required decimal Amount { get; set; }
        [ForeignKey("CoverId")]
        public required CoverEntity Cover { get; set; }
    }
}