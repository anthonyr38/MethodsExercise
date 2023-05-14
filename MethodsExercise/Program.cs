using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            Exercise1();


            //Exercise 2
            

            Console.WriteLine($"ADD {AddMe(12,5)}");
            Console.WriteLine($"SUBTRACT {SubtractMe(12, 5)}");
            Console.WriteLine($"MULTIPLY {MultiplyMe(12, 5)}");
            Console.WriteLine($"DIVIDE {DivideMe(12, 5)}");
            Console.WriteLine($"MODULUS (REMAINDER) {ModulusMe(12, 5)}");

        }
        // C# Methods Exercise, Sunday Practice 05_14_2023

        // Exercise 1
        public static void Exercise1()
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What the initial of your last name?");
            string lastInitial = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine("What city or country would you like to visit?");
            string visitLocation = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string favFood = Console.ReadLine();

            Console.WriteLine($"Hi {userName} {lastInitial}. Thank you for visiting our travel site and telling us about yourself.");
            Console.WriteLine($"We have prepared a wonderful package for you to visit {visitLocation}.");
            Console.WriteLine($"This package will include airfare in a private {favColor} airplane, hotel,");
            Console.WriteLine($"and front row tickets to a performance by {favBand}.");
            Console.WriteLine($"{favBand} will be accompanied by a giant dancing {favAnimal}.");
            Console.WriteLine($"We are also including all your meals at an all you can eat {favFood} bar");
        }

        //Exercise 2
        public static int AddMe(int num1, int num2)
        {
            return (num1 + num2);
        }

        public static int MultiplyMe(int num1, int num2)
        {
            return (num1 * num2);
        }

        public static int SubtractMe(int num1, int num2)
        {
            return (num1 - num2);
        }

        public static int DivideMe(int num1, int num2)
        {
            return (num1 / num2);
        }

        public static int ModulusMe(int num1, int num2)
        {
            return (num1 % num2);
        }
    }
    
}
            /* original course submittal. I want to redo the exercise
             * for additioinal practice. 05_14_2023
            //C# Methods Exercise 1
            
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("What the initial of your last name?");
            string lastInitial = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            string favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();

            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();

            Console.WriteLine("What city or country would you like to visit?");
            string visitLocation = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            string favFood = Console.ReadLine();

            Console.WriteLine($"Hi {userName} {lastInitial}. Thank you for visiting our travel site and telling us about yourself.");
            Console.WriteLine($"We have prepared a wonderful package for you to visit {visitLocation}.");
            Console.WriteLine($"This package will include airfare in a private {favColor} airplane, hotel,");
            Console.WriteLine($"and front row tickets to a performance by {favBand}.");
            Console.WriteLine($"{favBand} will be accompanied by a giant dancing {favAnimal}.");
            Console.WriteLine($"We are also including all your meals at an all you can eat {favFood} bar");


            //C# Methods Exercise 2

            Console.WriteLine("C# Methods Exercise 2");

            //Console.WriteLine("Please enter first number.");
            //int num1 = Console.ReadLine();

            //Console.WriteLine("please enter second number.");
            //int num2 = Console.ReadLine();

            int num1 = 4;
            int num2 = 7;




            //Calling Methods of Mathematical Operators
            // int twoPlusTwo = Add(2, 2);
            // Console.WriteLine(twoPlusTwo);
            // Other option
            // Console.WriteLine(Add(2, 2));


            Add(num1, num2);

            Multiply(3, 3);

            Subtract(3, 3);

            Divide(3, 3);

            Modulus(2, 2);
            */

        /*
            public static int Add(int num1, int num2)
            {
                return (num1 + num2);
            }

            public static int Multiply(int num1, int num2)
            {
                return (num1 * num2);
            }

            public static int Subtract(int num1, int num2)
            {
                return (num1 - num2);
            }

            public static int Divide(int num1, int num2)
            {
                return (num1 / num2);
            }

            public static int Modulus(int num1, int num2)
            {
                return (num1 % num2);
            }
            */