﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random() //ActionsResult can be one of View(),PartialView(),Content(),Redirect(),Json(),File()
        {
            var movie = new Movie() {Name = "Shrek!"};
            return View(movie);
        }

        [Route("movies/released/{year}/{month:regex(\\d{4}):range(1,12)}")] //Using attribute routes which are new n better!
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}