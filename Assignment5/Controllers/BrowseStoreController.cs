using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Assignment5.Data;
using Assignment5.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

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
