using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JWT.Domain.Models
{
    public class User: BaseEntry
    {
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public string Name { get; set; }
        public string Token { get; set; }

    }
}
