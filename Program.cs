using Course;
using System;
using System.Dynamic;
using System.Globalization;
using System.Numerics;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Course.Entities;
using Course.Entities.Enums;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow that's awesome");

            Post p1 = new Post(DateTime.Now, "Title", "", 3);
            p1.addComment(c1);
            p1.addComment(c2);


            Console.WriteLine(p1);

        }

    }
}