using System;

namespace HelloAppCore5
{
   public class Program
    {
       public static void Main()
        {
            Console.WriteLine(CreateMsg());
            Console.ReadLine();
        }
        public static string CreateMsg()
        {
           return "Hello World!";
        }
    }
}
