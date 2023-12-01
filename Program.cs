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

            Account acc1 = new Account(1001, "Alex", 500);
            Account acc2 = new SavingAccount(1002, "Anna", 500, 0.01);

            acc1.WithDraw(10);
            acc2.WithDraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);




        }

    }
}