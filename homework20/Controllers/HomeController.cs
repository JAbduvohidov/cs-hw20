using homework20.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using homework20.DataContext;

namespace homework20.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PersonRepository _personRepository;

        public HomeController(ILogger<HomeController> logger, PersonRepository personRepository)
        {
            _logger = logger;
            _personRepository = personRepository;
        }

        public IActionResult IndexAsync()
        {
            var persons = _personRepository.GetPersons();
            return View(persons);
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
