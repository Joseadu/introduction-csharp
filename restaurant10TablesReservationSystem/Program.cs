using System;

/*
 * 1. Validar si el usuario existe o si se tiene que registrar
 * 2. El programa debe ser capaz de darle la bienvenida a un usuario si existe
 * 3. El programa debe repetirse hasta que se registren las 10 personas
 */

namespace restaurant10TablesReservationSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] userNames = new string[5] { "", "", "", "", "" };
            int arrayCurrentIndex = 0;
            bool userType;

            Console.WriteLine("Welcome to our restaurant");

            while(arrayCurrentIndex < 5)
            {
                //if(arrayCurrentIndex == 5)
                //{
                //    Console.WriteLine("The restaurant is full, try again tomorrow");
                //    Environment.Exit(0);
                //}
                Console.WriteLine("Are you a registered user? Write 'true' in case you don't, write 'false' to register");
                userType = Convert.ToBoolean(Console.ReadLine());
                if(userType == true)
                {
                    Console.WriteLine("Hello you are a registered user, please enter your name");
                    string userToSearch = Console.ReadLine();
                    Console.WriteLine("The user your searched is {0}", userToSearch);
                    int index = Array.IndexOf(userNames, userToSearch);
                    if(index == -1)
                    {
                        Console.WriteLine("User not found, try again or register");
                    } else
                    {
                        Console.WriteLine("Welcome {0}, it is a pleasure to serve you", userNames[index]);
                    }
                } else if (userType == false)
                {
                    Console.WriteLine("Please try and remember your user name");
                    userNames[arrayCurrentIndex] = Console.ReadLine();
                    Console.WriteLine("Your user name has been saved successfully, your user name is > {0}", userNames[arrayCurrentIndex]);
                    arrayCurrentIndex++;
                }
            }
            Console.WriteLine("The restaurant is full, try again tomorrow. There are the guests for today");
            foreach(string userName in userNames)
            {
                Console.WriteLine("User name: > {0}", userName);
            }
            Environment.Exit(0);
        }
    }
}
