using ComicBook.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ComicBook.Controllers
{
    public class SeriesController : Controller
    {
        SeriesRepository _seriesRepositor = null;

        // GET: Series
        public ActionResult Index()
        {
            var series = _seriesRepositor.GetSeries();
            return View(series);
        }
        public SeriesController()
        {
            _seriesRepositor = new SeriesRepository();
        }

        public ActionResult Detail(int? id)
        {
            if (id == null)
            {
                return HttpNotFound();
            }
            var seriesDetail = _seriesRepositor.GetSeriesDetail((int)id);
            return View(seriesDetail);
        }

    }
}