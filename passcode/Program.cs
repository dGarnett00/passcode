using System;

namespace passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            while(code != "secret")
            {

            }
            Console.WriteLine("what is the passcode");
             code = Console.ReadLine();

            if(code =="secret")
            {
                Console.WriteLine("Authenticated");
            }
            else if(code !="secret")
            {
                Console.WriteLine("Not Authenticated");
            }
        }
    }
}
