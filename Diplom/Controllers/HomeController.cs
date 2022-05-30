
using Google.Protobuf.WellKnownTypes;
using JWT.Domain.Models;
using JWT.Domain.ViewModels;
using JWT.Infrastructure.Context;
using JWT.Infrastructure.UoW;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Tinkoff.InvestApi;
using Tinkoff.InvestApi.V1;

namespace JWT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly InvestApiClient _investApiClient;
        private UnitOfWork _uow;
        public HomeController(ILogger<HomeController> logger,
            UnitOfWork uow,
            InvestApiClient investApiClient)
        {
            _logger = logger;
            _uow = uow;
            _investApiClient = investApiClient;
        }


       
        public async Task<IActionResult> Index(string NameFilter)
        {
            //var model = new CandlesViewModel()
            //{
            //    Candles = new List<CandlesItem>()
            //};
            //var bonds = await _investApiClient.Instruments.BondsAsync();
            //foreach (var item in bonds.Instruments.Select(x => x.Figi).Take(10))
            //{
            //    var cand = new CandlesItem()
            //    {
            //        Figi = item,
            //        Candle = await _investApiClient.MarketData.GetCandlesAsync(new GetCandlesRequest()
            //        {
            //            Figi = item,
            //            From = Timestamp.FromDateTime(DateTime.UtcNow.AddDays(-7)),
            //            To = Timestamp.FromDateTime(DateTime.UtcNow),
            //            Interval = CandleInterval.Hour
            //        })
            //    };
            //    model.Candles.Add(cand);
            //}
            //if (User.Claims.ToList().Count != 0)
            //{
            //    var uid = User.Claims.Where(x => x.Type == "Id").FirstOrDefault().Value;
            //    var user = _uow.Users.Get(int.Parse(uid));
            //    ViewBag.favor = user.Items;

            //}

            //var model = _uow.Items.GetAll().ToList().Select(s=> new ItemViewModel()
            //{
            //    id = s.Id.ToString(),
            //    Name = s.Name,
            //    ImageByte = s.Image,
            //    Price = s.Price


            //});

            //if (!String.IsNullOrEmpty(NameFilter))
            //{
            //    model = model.Where(s => s.Name.Contains(NameFilter));
            //}
            //if (Request.Headers != null)
            //    if (Request.Headers["X-Requested-With"] == "XMLHttpRequest")
            //    return PartialView("_Indexpart", model);

            //var investApiClient = new ServiceCollection()
            //    .AddInvestApiClient((_, x) => x.AccessToken = "t.uysh4yKgQ4ynjw5-uwZ_r83u9Izwupa_k4Hglown62A3RtZ7wUjbb7jtFj7D0W7CSDqI7bSbatroA0gZob1ufg")
            //    .BuildServiceProvider()
            //    .GetService<InvestApiClient>();

            return View();
        }
        
        public async Task<IActionResult> Home()
        {
            
            //var model = _uow.Items.GetAll().ToList().Select(s => new ItemViewModel()
            //{
            //    id = s.Id.ToString(),
            //    Name = s.Name,
            //    ImageByte = s.Image,
            //    Price = s.Price,
            //    Description = s.Description

            //}).Take(7).ToList();
            return View();


        }

        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
