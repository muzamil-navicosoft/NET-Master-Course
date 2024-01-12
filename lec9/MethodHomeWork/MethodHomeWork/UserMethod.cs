using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHomeWork
{
    public static class UserMethod
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome To Our very Own Consol Applicaton");

        }
        public static string AskUserName()
        {
            Console.WriteLine("Please Enter your Name");
            string name = Console.ReadLine();
            return name;
        }
        public static void GreetUserWithName(string userName)
        {
            Console.WriteLine($"Hello {userName} to The new World of .NET");
        }
    }
}
