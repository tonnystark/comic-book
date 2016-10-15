﻿using ComicBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ComicBook.Data
{
    public static class Data
    {       
        static Data()
        {
            InitData();
        }
        public static ComicBooks[] ComicBooks { get; private set; }
        public static Series[] Series { get; private set; }

        private static void InitData()
        {
            var series = new Series[]
            {
                new Series()
    {
        Id = 1,
        Title = "The Amazing Spider-Man",
        DescriptionHtml = "<p>The Amazing Spider-Man (abbreviated as ASM) is an American comic book series published by Marvel Comics, featuring the adventures of the fictional superhero Spider-Man. Being the mainstream continuity of the franchise, it began publication in 1963 as a monthly periodical and was published continuously, with a brief interruption in 1995, until its relaunch with a new numbering order in 1999. In 2003 the series reverted to the numbering order of the first volume. The title has occasionally been published biweekly, and was published three times a month from 2008 to 2010. A film named after the comic was released July 3, 2012.</p>"
    },
    new Series()
    {
        Id = 2,
        Title = "Bone",
        DescriptionHtml = "<p>Bone is an independently published comic book series, written and illustrated by Jeff Smith, originally serialized in 55 irregularly released issues from 1991 to 2004.</p>"
    }
            };

            var comicBooks = new ComicBooks[]
            {
                new ComicBooks()
            {
                ID = 1,
                Series = series[0],
                IssueNumber = 700,
                DescriptionHtml = "<p>Final issue! Witness the final hours of Doctor Octopus' life and his one, last, great act of revenge! Even if Spider-Man survives... <strong>will Peter Parker?</strong></p>",
                Artist = new Artist[]
             {
                    new Artist() {Name = "Script", Role = "Dan Slott" },
                    new Artist() {Name = "Pencils", Role = "Humberto Ramos" },
                    new Artist() {Name = "Inks", Role = "Victor Olazaba" },
                    new Artist() {Name = "Colors", Role = "Edgar Delgado" }
               }
            },
              new ComicBooks()
       {
                  ID = 2,
            Series = series[0],
        IssueNumber = 657,
        DescriptionHtml = "<p><strong>FF: THREE TIE-IN.</strong> Spider-Man visits the FF for a very private wake--just for family.</p>",
        Artist = new Artist[]
        {
            new Artist() { Name = "Dan Slott", Role = "Script" },
            new Artist() { Name = "Marcos Martin", Role = "Pencils" },
            new Artist() { Name = "Marcos Martin", Role = "Inks" },
            new Artist() { Name = "Muntsa Vicente", Role = "Colors" },
            new Artist() { Name = "Joe Caramagna", Role = "Letters" }
        },
        Favorite = false
    },
    new ComicBooks()
    {
        ID = 3,
     Series = series[1],
        IssueNumber = 50,
        DescriptionHtml = "<p><strong>The Dungeon & The Parapet, Part 1.</strong> Thorn is discovered by Lord Tarsil and the corrupted Stickeaters and thrown into a dungeon with Fone Bone. As she sleeps, a message comes to her about the mysterious \"Crown of Horns\".</p>",
        Artist = new Artist[]
        {
            new Artist() { Name = "Jeff Smith", Role = "Script" },
            new Artist() { Name = "Jeff Smith", Role = "Pencils" },
            new Artist() { Name = "Jeff Smith", Role = "Inks" },
            new Artist() { Name = "Jeff Smith", Role = "Letters" }
        },
        Favorite = false
    }
            };

            Series = series;
            ComicBooks = comicBooks;
        }
    }
}




