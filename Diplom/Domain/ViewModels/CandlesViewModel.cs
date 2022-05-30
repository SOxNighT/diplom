using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Tinkoff.InvestApi.V1;

namespace JWT.Domain.ViewModels
{
    public class CandlesViewModel
    {
        public List<CandlesItem> Candles { get; set; }
    }

    public class CandlesItem
    {
        public GetCandlesResponse Candle { get; set; }
        public string Figi { get; set; }
    }
}