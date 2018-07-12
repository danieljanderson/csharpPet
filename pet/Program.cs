// things i have learned translating this app from javascript to c#
// learned public functions anyone can call the methods.
// protected only classes can call those methods.  so i would need to call generatedRandomNumber inside the class pet. 
using System;

namespace pet
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class Pet{
        private string name;
        private int food = 10;
        private int energy = 10;
        private int happiness = 10;
        protected static int generateRandomNumber(int min, int max){
            //Random is a object in the System class and I am making a new instance of it here.
            Random rnd =new Random();
            int randomNumber = rnd.Next(min,max);
            return randomNumber;
        }
       
    }
}
