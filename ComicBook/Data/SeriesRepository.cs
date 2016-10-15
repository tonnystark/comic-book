using ComicBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBook.Data
{
    public class SeriesRepository
    {
        public Series[] GetSeries()
        {
            return Data.Series;
        }
        public Series GetSeriesDetail(int id)
        {
            Series seriesToReturn = null;

            foreach (var series in Data.Series)
            {
                if (series.Id == id)
                {
                    seriesToReturn = series;
                    break;
                }
            }

            if (seriesToReturn != null)
            {
                // TODO Get the comic books for this series
                var comicBooks = new ComicBooks[0];
                foreach (var item in Data.ComicBooks)
                {
                    if(item.Series != null && item.Series.Id == id)
                    {
                        Array.Resize(ref comicBooks, comicBooks.Length + 1);
                        comicBooks[comicBooks.Length - 1] = item;
                    }
                }
                seriesToReturn.Issues = comicBooks;
            }

            return seriesToReturn;
        }

    }
}