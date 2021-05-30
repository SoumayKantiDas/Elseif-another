using System;

namespace Elseif_another
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a chracter: ");
            char c = (char)Console.Read();
            if(char.IsUpper(c))
            {
                Console.WriteLine("character is upper case");


            }
            else if(char.IsLower(c))
            {
                Console.WriteLine("Charecter is in lower case");
            }
            else if(char.IsDigit(c))
            {
                Console.WriteLine("This is a Digit");
            }
            else
            {
                Console.WriteLine("This is not alphabetic");
            }
        }
    }
}
