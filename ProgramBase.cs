using System;
using System.Collections;
using System.IO;
using System.Security.Cryptography;

namespace MyCSharp
{
    internal class ProgramBase
    {

        public static string Decrypt(string ciperText, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream(Convert.FromBase64String(ciperText));
            CryptoStream cs = new CryptoStream(ms, key.CreateDecryptor(), CryptoStreamMode.Read);
            StreamReader sr = new StreamReader(cs);
            return sr.ReadToEnd();
        }

        public static string Encrypt(string plain, SymmetricAlgorithm key)
        {
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, key.CreateEncryptor(), CryptoStreamMode.Write);
            StreamWriter sw = new StreamWriter(cs);

            sw.Write(plain);
            sw.Flush();
            cs.FlushFinalBlock();

            return (Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length));
        }

        public static void UseArrayList()
        {
            ArrayList array = new ArrayList();
            array.Add("First");
            array.Add("Second");
            array.Add(3);
            array.Add(DateTime.Now);

            Console.WriteLine("at first:");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------");
            Console.WriteLine("string after insertion:");

            array.Insert(1, "ADDDED SEC");
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        public static void UseEncryptDecrypt()
        {
            DESCryptoServiceProvider key = new DESCryptoServiceProvider();
            Console.WriteLine("Enter you message: ");

            string plainText = Console.ReadLine();

            string ciperText = Encrypt(plainText, key);

            Console.WriteLine("\nCiper Text" + Encrypt(plainText, key));

            Console.WriteLine("plan text: " + Decrypt(ciperText, key));
        }

        static int AddAndReturn(int a, int b)
        {
            int added = 0;
            added = a + b;
            return added;
        }

        static void Basics()
        {
            int x = 2;
            string name = "giorgi";
            string surname = "datunashvili";
            bool isWorking = true;

            Console.WriteLine("Hello World!");
            Console.WriteLine("Number is: " + x);
            Console.WriteLine("My Name Is:" + name + " " + surname);
            Console.WriteLine(isWorking);
        }

        static void ChangeNames(out string firstEmp, out string secEmp)
        {
            firstEmp = "Diana";
            secEmp = "Kate";
            Console.WriteLine($"Outside main method \n{firstEmp} \n{secEmp}");
        }

        static void ChangeNamesRef(ref string firstEmpRef, ref string secondEmpRef)
        {
            firstEmpRef = "changedFirst";
            secondEmpRef = "changedSecond";
            Console.WriteLine($"Ref Change: {firstEmpRef} {secondEmpRef}");
        }

        static void ConvertAndDisplay()
        {
            float floatNumber = 3.9f;

            var convertedFloat = Convert.ToInt32(floatNumber);
            Console.WriteLine(convertedFloat);
        }

        static void DisplayStuff()
        {
            Console.WriteLine("Done");
        }

        static void OutsAndRefs()
        {
            string firstEmployee, secondEmployee;
            firstEmployee = "Bitch";
            secondEmployee = "Ass";

            Console.WriteLine($"Inside: {firstEmployee} {secondEmployee}");

            ChangeNames(out firstEmployee, out secondEmployee);

            ChangeNamesRef(ref firstEmployee, ref secondEmployee);
            Console.WriteLine(firstEmployee + " " + secondEmployee);
        }

        static void PerformAddition(int x, int y)
        {
            int addedResult = 0;
            addedResult = x + y;
            Console.WriteLine($"{x}+{y} = {addedResult}");
        }



        static void SayHi()
        {
            Console.WriteLine("hi from static method");
        }

        static void UseClass()
        {
            Person persOne = new Person();
            persOne.FirstName = "Giorgi";
            persOne.LastName = "Datunashvili";
            persOne.DateOfBirth = DateTime.Now;
            persOne.Country = "Georgia";

            Person N = new Person();

            Console.WriteLine(persOne.FirstName);
            Console.WriteLine(N.FirstName);
        }
    }
}