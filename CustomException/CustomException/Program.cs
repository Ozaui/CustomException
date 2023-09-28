using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomException
{
    class LoginException : Exception
    {
        public LoginException(string message) : base(message) 
        {
            
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Login("ÖzayMelihYıldız", "password");
            }catch (LoginException ex) 
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
        static void Login(string username, string password)
        {
            if(username.Contains(" ")) 
            {
                throw new LoginException("Bosluk içeremez");
            }
            if(password.Length <8)
            {
                throw new LoginException("8 karakterden büyük olmalı");
            }
        }
    }
}
