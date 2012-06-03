// This is a comment. A comment is anything following the "//"
// A comment has no effect on the program and is used to leave notes behind for anyone reading the code.
// Hey computer! You SUCK!
// See, the comments are completely ignored by the computer.
// I will be using comments to explain what is happening in each line of code that I write. 


// this following block we can ignore for now, and I will explain it later
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// I will explain namespaces later
namespace Lesson1
{
    // I will explain classes later
    class Program
    {
        // this is a function which I will explain later, but it for this example it is important to know
        // that this "Main" function is where you program starts.
        static void Main(string[] args)
        {
            // this is our first command. what the line below is doing is going to the console and printing out the 
            // text "Hello World" (no quotations). You can put what ever text you want in the quotes and it will
            // be displayed on the screen. Just please be civil.
            Console.WriteLine("Hello World");

            // After printing the words "Hello world" to the screen if there isn't anymore code the progam will
            // exit immediately. Since computers run so fast, we will never see it.
            // This next line is to keep the program to wait until the user presses a key, before proceeding
            // so we can see our output.
            Console.ReadKey();

            // Next we are going to take in input from the user. We will ask the user his name and print it back to him.
            // Here we will ask the user to tell us his name.
            Console.WriteLine("What is your name?");

            // If we are going take the users name we need to store it some where. This is where variables come in.
            // This is a variable. It is a string and its name is "username";
            string username;

            // This line of code below is used to get input from the user, and store his answer in the variable "username".
            username = Console.ReadLine();

            // Now that we have his name, we can print it back to him.
            Console.WriteLine("Hello " + username);

            // Now that we are done, we will want to wait again, so we can allow the user to see his input.
            Console.ReadKey();
        }
    }
}
