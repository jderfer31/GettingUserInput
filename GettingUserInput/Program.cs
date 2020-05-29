using System;

namespace GettingUserInput
{
    class Program
    {
        static void Main(string args)
        {
            args = "";
            string name;
            string age;

            Console.WriteLine("Enter your name: "); //This prompts user with screen
             name = Console.ReadLine(); //This prompts user for input from Enter your name. The string name sets the Console.ReadLine as a variable
            Console.WriteLine("Enter your age: "); //You can keep requesting info this way to interact with user
             age = Console.ReadLine(); // set the string variable to age and the input is stored into variable age
            Console.WriteLine("Hello " + name + " You are " + age + "years old " ); //This responds by saying hello and whatever the user put for name



            Console.ReadLine();
        }
    }
}
