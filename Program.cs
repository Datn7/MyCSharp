using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;

namespace MyCSharp
{
    class Program : ProgramBase
    {
        static void Main(string[] args)
        {
            List<MyClasses> myClasses = new List<MyClasses>();

            IList<string> secondList = new List<string>();


            myClasses.Add(new MyClasses { Name = "F", Id = 1, });
            myClasses.Add(new MyClasses { Name = "U", Id = 2, });
            myClasses.Add(new MyClasses { Name = "Q", Id = 3, });

            foreach (var item in myClasses)
            {
                Console.WriteLine(item.Id + item.Name);
            }
        }
    }
}
