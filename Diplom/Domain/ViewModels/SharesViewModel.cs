using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tinkoff.InvestApi.V1;

namespace JWT.Domain.ViewModels
{
    public class SharesViewModel
    {
        public List<Share> Shares { get; set; }
    }
}