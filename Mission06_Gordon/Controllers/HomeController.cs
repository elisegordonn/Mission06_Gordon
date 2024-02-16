using Microsoft.AspNetCore.Mvc;
using Mission06_Gordon.Models;
using System.Diagnostics;

namespace Mission06_Gordon.Controllers
{
    public class HomeController : Controller
    {
        private FilmCollectionContext _context;
        public HomeController(FilmCollectionContext temp) //constructor
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetToKnowJoel()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieForm()
        {
                return View();   
        }
        
        [HttpPost]
        public IActionResult MovieForm(Form response)
        {
            // return to the form if the model isn't valid (empty required fields)
            if (!ModelState.IsValid)
            {
                return View(response);
            }
            else
            {
                _context.Forms.Add(response); //add record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
        }

    }
}
