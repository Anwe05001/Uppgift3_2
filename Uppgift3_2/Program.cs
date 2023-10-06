using System;
namespace Uppgift_3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket land vann fotbolls-VM för damer år 2015?");
            string svar = Console.ReadLine().ToLower();

            if(svar == "usa")
            {
                Console.WriteLine("Helt Rätt!");
            }
            if (svar != "usa") 
            {
                Console.WriteLine("Fel Svar!");
            }
        }
    }
}