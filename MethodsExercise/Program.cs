namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            
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
            

        }
    }
}
