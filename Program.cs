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
        static void Main1()
        {
            Console.Clear();
            new Game().Init();
        }
    



        public static void Main()
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
                    Console.WriteLine("4 - Start Game");
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
                    else if(option.Key == ConsoleKey.D4)
                    {
                        new Game().Init();
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