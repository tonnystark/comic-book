using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBook.Models
{
    public class ComicBooks
    {
        public int ID { get; set; }
        public Series Series { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artist { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return Series != null ? Series.Title + " #" + IssueNumber : null;
            }
        }
        // seria-title-1212.jpg
        public string CoverImageFileName
        {
            get
            {
                return Series != null ? Series.Title.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg" : null;
            }
        }
    }
}