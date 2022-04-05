using System;

namespace MethodExercise
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();

            Console.WriteLine("How old is your dog?");
            string dogAge = Console.ReadLine();

            Console.WriteLine("What is your dog's name?");
            string dogName = Console.ReadLine();

            Console.WriteLine("What color is your dog?");
            string dogColor = Console.ReadLine();

            Console.WriteLine($"{userName} and loyal dog {dogName} went to the same park every day affter work.");
            Console.WriteLine($"One day, {userName} did not return home from work. {dogName} was very concerned.");
            Console.WriteLine($"When a loyal friend of {userName} came into the home, {dogName} bolted out of the door.");
            Console.WriteLine($"Later that day, the local hospital was very surprised to see a {dogColor} dog run in through the automatic door.");
            Console.WriteLine($"{userName} was not as surprised to see {dogName} rush into the hospital room.  I guess that's what happens when one walks their local friend near the hospital every day for {dogAge} years.");

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first number");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply by the first number");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract from the first number");
            num2 = int.Parse(Console.ReadLine());

            int subtract = Sum(num1, -num2);

            Console.WriteLine($"The result is {subtract}");

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide the first number by");
            num2 = int.Parse(Console.ReadLine());

            int divide = (num1/ num2);

            Console.WriteLine($"The result is {divide}");


            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a second number to find the remainder");
            num2 = int.Parse(Console.ReadLine());

            int modulus = (num1 % num2);

            Console.WriteLine($"The result is {modulus}");

        }

        public static int Sum(params int[] list)
        {
            int sum = 0;
            for (int i = 0; i< list.Length; i++ )
            {
                sum = sum + list[i];
            }
            return sum;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

    }
}

