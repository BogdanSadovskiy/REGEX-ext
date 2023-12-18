
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
                Console.WriteLine("Input Ukrainian number:");
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


        private (bool, string) PassValidation(string password)
        {
            string descr= "";
            bool isTrue = true;
            int i = 1;
            //Length valid > 8
            if (password.Length<8)  
            {
                descr+= i.ToString()+") Pass must to be at least 8 chars\n";
                isTrue = false;
                i++;
            }

            // Length valid <=32
            if (password.Length >= 32)     
            {
                descr += i.ToString() + ") Pass must not to be more then 32 chars\n";
                isTrue = false;
                i++;
            }

            // lowercase validation
            if(!Regex.Match(password, "(?=.*[a-z])[A-Za-z\\d#$@!%&*?]+").Success) 
            {
                descr += i.ToString() + ") Pass must has at least one LOWERCASE letter\n";
                isTrue = false;
                i++;

            }

            // uppercase validation
            if (!Regex.Match(password, "(?=.*[A-Z])[A-Za-z\\d#$@!%&*?]+").Success)
            {
                descr += i.ToString() + ") Pass must has at least one UPPERCASE letter\n";
                isTrue = false;
                i++;
            }

            //special symbol validation
            if (!Regex.Match(password, "(?=.*[#$@!%&*?])[A-Za-z\\d#$@!%&*?]+").Success)
            {
                descr += i.ToString() + ") Pass must has at least one SPECIAL symbol\n";
                isTrue = false;
                i++;
            }
            //------------------------------------------------------------------------------------------------------------//
            if (isTrue)
            {
                // full regex expression:
                return (Regex.Match(password, "^(?=.*[a-z])(?=.*[A-Z])(?=.*\\d)(?=.*[#$@!%&*?])[A-Za-z\\d#$@!%&*?]{8,33}$").Success,
                    "Pass is valid");
                /////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            }
            return (isTrue, descr);
        }
        public void IsPassWordValid()
        {
            while (true)
            {
                
                Console.WriteLine("Input Password:");
                Console.WriteLine("(Password has to be:\n" +
                    "At least 8 chars but not more then 32\n"  + 
                    "One Uppercase letter\n" + 
                    "One lowercase letter\n" + 
                    "One digit\n"+
                    "One special symbol)");
                Console.WriteLine("E - exit\n");

                string str = Console.ReadLine();
                Console.Clear();
                if (str == "e" || str == "E") { return; }
               var Pass = PassValidation(str);
                Console.WriteLine(Pass.Item1+ "\n" + Pass.Item2 + "\n\n");


            }
        }
    }
}
