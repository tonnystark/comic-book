﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBook.Controllers
{
    public class ComicBooksController : Controller
    {
        public ActionResult Detail()
        {
            return View();         
        }
        
    }
}