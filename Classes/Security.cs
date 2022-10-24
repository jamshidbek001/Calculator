using System;

namespace CALCULATOR.Classes
{
    class Security
    {
        public void CheckPassword()
        {
            string password = "";
            do
            {
                Console.WriteLine("Enter your password");
                password = Console.ReadLine();
            } while (password != "pa$$word");
        }
    }
}