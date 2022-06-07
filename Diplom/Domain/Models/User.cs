using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JWT.Domain.Models
{
    public class User: BaseEntry
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }
        public List<Portfolio> Portfolio { get; set; }

    }
}
