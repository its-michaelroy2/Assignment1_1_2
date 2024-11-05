namespace Assignment1_1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assignment 1.1.2
            Console.WriteLine("Below are the Min & Max values for each Data Type:");
            Console.WriteLine();

            Console.WriteLine($"Int: Min = {int.MinValue}, Max = {int.MaxValue}");

            Console.WriteLine();

            Console.WriteLine($"Double: Min = {double.MinValue}, Max = {double.MaxValue}");

            Console.WriteLine();

            Console.WriteLine($"Float: Min = {float.MinValue}, Max = {float.MaxValue}");

            Console.WriteLine();

            Console.WriteLine($"Decimal: Min = {decimal.MinValue}, Max = {decimal.MaxValue}");

            Console.WriteLine();


            //Assignment 1.1.3
            Console.WriteLine("Please enter numbers for Addition below:");
            Console.WriteLine();

            Console.WriteLine("Please enter the first number: ");
            double number1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the second number: ");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double sum = number1 + number2;
            
            Console.WriteLine($"The sum of {number1} and {number2} is {sum}");
            Console.WriteLine();

            //Assignment 1.1.4
            Console.WriteLine("Please enter numbers for Division below:");
            Console.WriteLine();

            Console.WriteLine("Please enter the first number: ");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter the second number: ");
            double number4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double result = number3 / number4;

            Console.WriteLine($"The value of {number3} divided by {number4} is {result}");
            Console.WriteLine();

            Console.WriteLine("Please press any key to exit the program.");
            Console.ReadKey(intercept: true);
        }
    }
}
