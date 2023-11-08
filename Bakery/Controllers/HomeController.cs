using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Security.Claims;

namespace Bakery.Controllers
{
  public class HomeController : Controller
  {
    private readonly BakeryContext _db;
    private readonly UserManager<ApplicationUser> _userManager;

    public HomeController(UserManager<ApplicationUser> userManager, BakeryContext db)
    {
      _userManager = userManager;
      _db = db;
    }

        [HttpGet("/")]
        public ActionResult Index()
        {
            var flavors = _db.Flavors.ToList(); 
            var treats = _db.Treats.ToList(); 

            var viewModel = new HomeViewModel
            {
                Flavors = flavors,
                Treats = treats
            };

            return View(viewModel);
        }
  }
}