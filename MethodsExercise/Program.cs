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
            Console.WriteLine($"Today I saw {userName} riding a {userColor} {userAnimal} while screaming the" +
                              $"lyrics from {userBand}'s latest song at the top of their longs. Mondays...");
            
        }
    }
}
