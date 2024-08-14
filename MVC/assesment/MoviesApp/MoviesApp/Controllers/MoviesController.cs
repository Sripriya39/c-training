using MoviesApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using static System.Net.WebRequestMethods;

namespace MoviesApp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index()
        {
            using (var db = new MoviesDBContext())
            {
                var movies = db.Movies.ToList();
                return View(movies);
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            if (ModelState.IsValid)
            {
                using (var db = new MoviesDBContext())
                {
                    db.Movies.Add(movie);
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(movie);
        }

        public ActionResult Edit(int id)
        {
            using (var db = new MoviesDBContext())
            {
                var movie = db.Movies.Find(id);
                if (movie == null)
                {
                    return HttpNotFound();
                }
                return View(movie);
            }
        }

        [HttpPost]
        public ActionResult Edit(Movie movie)
        {
            if (ModelState.IsValid)
            {
                using (var db = new MoviesDBContext())
                {
                    db.Entry(movie).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return View(movie);
        }

        public ActionResult Delete(int id)
        {
            using (var db = new MoviesDBContext())
            {
                var movie = db.Movies.Find(id);
                if (movie == null)
                {
                    return HttpNotFound();
                }
                return View(movie);
            }
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            using (var db = new MoviesDBContext())
            {
                var movie = db.Movies.Find(id);
                db.Movies.Remove(movie);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
        }

        public ActionResult MoviesByYear(int year)
{
    using (var db = new MoviesDBContext())
    {
        var movies = db.Movies.Where(m => m.DateOfRelease.Year == year).ToList();
        return View(movies);
    }
}
    }
}