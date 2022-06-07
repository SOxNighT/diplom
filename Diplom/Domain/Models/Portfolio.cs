using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWT.Domain.Models
{
    public class Portfolio : BaseEntry
    {
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public int SumForStart { get; set; }
        public List<ShareStack> ShareStacks { get; set; }

        public Guid UserId { get; set; }

        [ForeignKey(nameof(UserId))]
        public User User { get; set; }
    }

    public class ShareStack : BaseEntry
    {
        [ForeignKey(nameof(ShareId))]
        public Share Share { get; set; }

        public Guid ShareId { get; set; }

        public int Count { get; set; }

    }
}
