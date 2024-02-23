using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mission06_Gordon.Models;
using System.Diagnostics;

namespace Mission06_Gordon.Controllers
{
    public class HomeController : Controller
    {
        private JoelHiltonMovieCollectionContext _context;
        public HomeController(JoelHiltonMovieCollectionContext temp) //constructor
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
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();
            
            return View("MovieForm", new Movies());   
        }
        
        [HttpPost]
        public IActionResult MovieForm(Movies response)
        {
            // return to the form if the model isn't valid (empty required fields)
            if (!ModelState.IsValid)
            {
                return View(response);
            }
            else
            {
                _context.Movies.Add(response); //add record to the database
                _context.SaveChanges();

                return View("Confirmation", response);
            }
        }

        public IActionResult Entries()
        {
            //Linq
            var movieSet = _context.Movies.Include(x => x.Category)
                .OrderBy(x => x.MovieId).ToList();
           

            return View(movieSet);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId == id);
            
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View("MovieForm", recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Movies mov)
        {
            _context.Update(mov);
            _context.SaveChanges();
            
            return RedirectToAction("Entries");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);

            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movies mov)
        {
            _context.Movies.Remove(mov);
            _context.SaveChanges();
            return RedirectToAction("Entries");
        }

    }
}
