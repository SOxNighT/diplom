using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace JWT.Domain.Models
{
    public class Share: BaseEntry
    {
        public string Figi { get; set; }
        public string Ticker { get; set; }
        public string Name { get; set; }
        public string Currency { get; set; }

    }
}
