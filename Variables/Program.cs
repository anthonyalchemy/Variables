using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string characterName = "Tom";
            int characterAge; //Declaring a variable
            characterAge = 25;
            //Two different ways of writing variables 
            //variable is where you store data types


            Console.WriteLine("There once was a man named " + characterName);
            Console.WriteLine("He was " + characterAge + " years old");

            //characterName = "Mike"; you can change the variable half way through the story 

            Console.WriteLine("He really likked the name " + characterName);
            Console.WriteLine("But didn't like being " + characterAge);


            Console.ReadLine();
        }
    }
}
