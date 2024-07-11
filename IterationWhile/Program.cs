using System;

namespace Iterations1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                /*  Console.Write("Type your name: ");
                  var input = Console.ReadLine();

                  if (string.IsNullOrEmpty(input))
                  {
                      break;
                  }

                  Console.WriteLine("@Echo : " + input);  */
    

                Console.Write("Type your name :");
                var input = Console.ReadLine();

                if(!String.IsNullOrEmpty(input))
                {
                    Console.WriteLine("@Echo: " + input);
                    continue;
                } 

                break;  

             


            }
        }
    }
}