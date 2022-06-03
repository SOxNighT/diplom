
using Google.Protobuf.WellKnownTypes;
using JWT.Domain.Models;
using JWT.Domain.ViewModels;
using JWT.Infrastructure.Context;
using JWT.Infrastructure.UoW;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using MvcContrib.UI.Grid;
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

        public async Task<IActionResult> Shares()
        {
            return View();
        }

        [HttpGet("data")]
        public async Task<IActionResult> GetData()
        {
            var investApiClient = new ServiceCollection()
                .AddInvestApiClient((_, x) => x.AccessToken = "t.uysh4yKgQ4ynjw5-uwZ_r83u9Izwupa_k4Hglown62A3RtZ7wUjbb7jtFj7D0W7CSDqI7bSbatroA0gZob1ufg")
                .BuildServiceProvider()
                .GetService<InvestApiClient>();

            var shares = await investApiClient.Instruments.SharesAsync();
            var data = shares.Instruments.ToList();
            return Json(data);
        }

        public async Task<IActionResult> Home()
        {
            return View();
        }


        public IActionResult PageNotFound()
        {
            return View();
        }
    }
}
