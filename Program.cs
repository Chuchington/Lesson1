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


            // Here we are going to take a look at flow control. We are going to make a menu of things we want the computer
            // to do.

            // first we are going to store weither or not we are done. By default we are not done until the user says so.
            bool exit = false;

            // we are going to set up of loop, where we keep doing thing until we are done.
            while (!exit)
            {
                // we are going to want to display the available commands to the user.
                Console.WriteLine("1.) Exit");
                Console.WriteLine("2.) Clear screen");
                Console.WriteLine("3.) Change foreground colors");
                Console.WriteLine("4.) Change background colors");

                Console.WriteLine(); // write a blank line
                Console.Write("What do you want me to do? "); // notic here we used write instead of write line, it does not make a line break.

                // here we take the users input and store it a characher key
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                // we can compare the value the user entered and do the appropriate actions
                if (input == '1')
                {
                    // set exit to true so we break out the loop
                    exit = true;
                }
                else if (input == '2')
                {
                    // a simple command to clear the screen
                    Console.Clear();
                }
                else if (input == '3')
                {
                    // to keep the code from getting to messy we will call a function to do the work
                    Console.ForegroundColor = RequestColor();
                }
                else if (input == '4')
                {
                    // we can reuse the same function so we don't have code the same logic multiple times
                    Console.BackgroundColor = RequestColor();
                }
                else // if the value does not enter any of the predefined commands we notify the user and tell them to try again
                {
                    Console.WriteLine("Sorry " + input + " is not a valid command.");
                }
            }

            // now that we exited the loop we can say good bye.
            Console.WriteLine("GoodBye!");

            // Now that we are done, we will want to wait again, so we can allow the user to see his input.
            Console.ReadKey();
        }

        // This is example of a simple function. This function takes in a value and clamps it between the
        // min and max value. This is useful when we want to constrain number but don't want to write this logic multiple 
        // times in our code.
        // Extra credit, this code can break if the min passed in is greater then the max. If we fix it in this code, it will be
        // be fixed everywhere this code is used.
        static float Clamp(float value, float min, float max)
        {
            // lets break down the components of this function

            // static - lets ignore this one for now
            // float - this is the return type. Every function can return a value. Here we are returning a float 
            // Clamp - this is the name of the function
            // ()  - this is the parameter list, we can pass values into a parameter list, for the function to use.
            // float value - this is the 1st parameter. it is a float and is named value
            // float min - 
            // float max - 

            if (value < min)
                return min;
            if (value > max)
                return max;
            return value;
        }

        // This is a function. By subdividing it out as a seperate "task" we can better organize our code. And
        // we can also reuse this code. If we were to add more colors to this function, we get it for both changing
        // the back and foreground colors.
        static ConsoleColor RequestColor()
        {
            ConsoleColor ourColor = ConsoleColor.Black;
            // we are going to set up of loop, where we keep doing thing until we are done. (pick any color that is not black)
            while (ourColor == ConsoleColor.Black)
            {
                Console.WriteLine("1.) Red");
                Console.WriteLine("2.) Blue");
                Console.WriteLine("3.) Green");
                Console.WriteLine("4.) Yellow");

                Console.WriteLine(); // write a blank line
                Console.Write("Pick a color? ");

                // here we take the users input and store it a characher key
                char input = Console.ReadKey().KeyChar;
                Console.WriteLine();

                if (input == '1')
                {
                    ourColor = ConsoleColor.Red;
                }
                else if (input == '2')
                {
                    ourColor = ConsoleColor.Blue;
                }
                else if (input == '3')
                {
                    ourColor = ConsoleColor.Green;
                }
                else if (input == '4')
                {
                    ourColor = ConsoleColor.Yellow;
                }
                else // if the value does not enter any of the predefined commands we notify the user and tell them to try again
                {
                    Console.WriteLine("Sorry " + input + " is not a valid command.");
                }
            }
            return ourColor;
        }
    }
}
