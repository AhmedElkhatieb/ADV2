﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADV_Session2_Assignment
{
    internal class BookFunctions
    {
        public static string GetTitle (Book B)
        {
            return B.Title;
        }
        public static string[] GetAuthors(Book B)
        {
            return B.Authors;
        }
        public static decimal GetPrice (Book B)
        {
            return B.Price;
        }
    }
}