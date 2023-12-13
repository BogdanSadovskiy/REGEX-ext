
using System.Text.RegularExpressions;

namespace mySpace
{
    internal class Exersice
    {

        public void IsEmailValid()
        {
            // Is Email valid
            while (true)
            {
                Console.WriteLine("Input Email:");
                Console.WriteLine("Email has not got #,=,+; Has only one @");
                Console.WriteLine("E - exit");

                string Email = Console.ReadLine();
                if (Email == "e" || Email == "E") { return; }
                var Email_ = Regex.Match(Email, "^[\\w-\\.]+@([\\w-]+\\.)+[\\w-]{2,4}$");
                if (Email_.Success)
                {
                    Console.WriteLine("Valided");
                }
                else { Console.WriteLine("Not valided"); }
            }
        }

        public void IsUkrainianNumberValid()
        {
            while (true)
            {
                Console.WriteLine("Input number:");
                Console.WriteLine("Number must be start from +380");
                Console.WriteLine("E - exit");

                string str = Console.ReadLine();
                if (str == "e" || str == "E") { return; }
                var UKR = Regex.Match(str, "^\\+(380)[\\d]{9}$");
                if (UKR.Success)
                {
                    Console.WriteLine("Number is valid");
                }
                else { Console.WriteLine("Number is not valid"); }

            }
        }
    }
}
