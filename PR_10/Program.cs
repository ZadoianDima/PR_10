using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PR_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введіть адресу електронної пошти: ");
            string email = Console.ReadLine();

            bool isValid = Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            
            if (isValid)
            {
                Console.WriteLine("Адреса електронної пошти дійсна");
            }
            else
            {
                Console.WriteLine("Адреса електронної пошти не дійсна");
            }
            Console.ReadLine();
        }
    }
}
