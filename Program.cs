using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using System.Text.Json;


namespace Project 
{
   internal class Program
    {
        static void Main()
        {
            Console.Clear();
            new Game().Init();
        }
    



        public static void Main1()
        {

            try
            {
                ConsoleKeyInfo option;

                    auth.UpdateUsers();

                do
                {
                    Console.WriteLine("\n1 - Sign in");
                    Console.WriteLine("2 - Sign up");
                    Console.WriteLine("3 - All Users");
                    Console.WriteLine("Esc -  exit");

                    option = Console.ReadKey(true);
                    Console.Clear();
                    if (option.Key == ConsoleKey.D1)
                    {
                        auth.LINQAutentification();
                    }
                    else if (option.Key == ConsoleKey.D2)
                    {
                        auth.Add();
                    }
                    else if (option.Key == ConsoleKey.D3)
                    {
                        auth.Print();
                    }

                } while (option.Key != ConsoleKey.Escape);
            }
            catch (IOException ex)
            {
                Console.WriteLine("IO Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
}


}