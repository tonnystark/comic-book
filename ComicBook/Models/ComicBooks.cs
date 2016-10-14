using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBook.Models
{
    public class ComicBooks
    {
        public int ID { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artist { get; set; }
        public bool Favorite { get; set; }

        public string DisplayText
        {
            get
            {
                return SeriesTitle + " #" + IssueNumber;
            }
        }
        // seria-title-1212.jpg
        public string CoverImageFileName
        {
            get
            {
              
                return SeriesTitle.Replace(" ", "-").ToLower() + "-" + IssueNumber + ".jpg"; ;
            }
        }
    }
}