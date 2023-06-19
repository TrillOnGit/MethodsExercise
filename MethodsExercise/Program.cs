using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;

namespace MethodsExercise
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            var userName = Console.ReadLine();
            Console.WriteLine("What's your favorite band?");
            var userBand = Console.ReadLine();
            Console.WriteLine("What's your favorite Color?");
            var userColor = Console.ReadLine();
            Console.WriteLine("What's your favorite animal?");
            var userAnimal = Console.ReadLine();
            
            //Code to confirm it runs properly.
            // Console.WriteLine($"Name: {userName} \nFavorite Color: {userColor}\n" +
            // $"Favorite Animal: {userAnimal}\nFavorite Band: {userBand}\n");
            //Short story
            Console.WriteLine($"Today I saw {userName} riding a {userColor} {userAnimal} while screaming the " +
                              $"lyrics from {userBand}'s latest song at the top of their longs. Mondays...");
           
            
            //----Exercise 2----//

            Console.WriteLine("What values would you like to use?");
            int val1 = Convert.ToInt32(Console.ReadLine());
            int val2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine($"Addition: {Add(val1, val2)}, Division: {Divide(val1, val2)}, Subtraction: "
            + $"{Subtract(val1, val2)}, Multiplication: {Multiply(val1, val2)}, Remainder: {Modulo(val1, val2)}");
            Console.WriteLine($"Params 2+4+5+6={Total(2, 4, 5, 6)}");
        }
        public static int Add(int num1, int num2)
        { 
            return num1 + num2;
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static float Divide(int num1, int num2)
        {
            var divnum1 = (float)num1;
            var divnum2 = (float)num2;
            return divnum1 / divnum2;
        }

        public static int Modulo(int num1, int num2)
        {
            return num1 % num2;
        }
        
        //If we want more numbers we can do this instead.
        public static int Total(params int[] numbers)
        {
            return numbers.Sum();
        }
    }
}
