using System.Diagnostics;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Tap2021Demo.DomainEntities;
using Tap2021Demo.Examples.Ef.Web.Models;
using Tap2021Demo.Infrastructure.DataAccess;

namespace Tap2021Demo.Examples.Ef.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IDataRepository _dataRepository;

        public HomeController(ILogger<HomeController> logger, IDataRepository dataRepository)
        {
            _logger = logger;
            _dataRepository = dataRepository;
        }

        public IActionResult Index()
        {
            var data = _dataRepository.Query<AccountHolder>().Take(10).ToArray();
            return View(data.Select(x => new AccountHolderViewModel
            {
                FirstName = x.FirstName,
                Id = x.Id,
                IdNo = x.IdNo,
                LastName = x.LastName
            }));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
