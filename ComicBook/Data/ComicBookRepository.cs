using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ComicBook.Models;

namespace ComicBook.Data
{
    public class ComicBookRepository
    {     

        public ComicBooks GetComicBook(int id)
        {
            return Data.ComicBooks.Where(x => x.ID == id).SingleOrDefault();
        }

        public ComicBooks[] GetComicBooks()
        {
            return Data.ComicBooks;
        }


    }
}