using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment5.Data;
using Assignment5.Models;

namespace Assignment5.Controllers
{
    public class BrowseStoreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


    }
}
