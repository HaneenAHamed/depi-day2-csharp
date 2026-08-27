namespace depi_day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Q1
            // Single-line comment

            int q1X = 10;
            int q1Y = 20;
            int q1Sum = q1X + q1Y;

            /*
               Multi-line comment:
               This program calculates
               the sum of two numbers.
            */

            Console.WriteLine(q1Sum);


            // Q2
            // Fixed errors in the original code

            int q2X = 10;
            int q2Y = 20;

            Console.WriteLine(q2X + q2Y);


            // Q3
            // Variables using proper naming conventions

            string fullName = "Haneen Alaa Hassan";
            int age = 21;
            decimal monthlySalary = 15000m;
            bool isStudent = true;


            // Q4
            // Demonstrating reference types

            Person person1 = new Person();
            person1.Name = "Haneen";

            Person person2 = person1;

            person2.Name = "Ahmed";

            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);


            // Q5
            // Arithmetic operations

            int q5X = 15;
            int q5Y = 4;

            Console.WriteLine("Sum: " + (q5X + q5Y));
            Console.WriteLine("Difference: " + (q5X - q5Y));
            Console.WriteLine("Product: " + (q5X * q5Y));
            Console.WriteLine("Division: " + (q5X / q5Y));
            Console.WriteLine("Remainder: " + (q5X % q5Y));


            // Q6
            // Remainder using the % operator

            int q6A = 2;
            int q6B = 7;

            Console.WriteLine(q6A % q6B);


            // Q7
            // Check if a number is greater than 10 and even

            int number = 14;

            if (number > 10 && number % 2 == 0)
            {
                Console.WriteLine("The number is greater than 10 and even.");
            }
            else
            {
                Console.WriteLine("Condition is not satisfied.");
            }


            // Q8
            // Explicit casting from double to int

            Console.Write("Enter a double number: ");

            double doubleNumber = double.Parse(Console.ReadLine());

            int intNumber = (int)doubleNumber;

            Console.WriteLine("Double value: " + doubleNumber);
            Console.WriteLine("Int value: " + intNumber);


            // Q9
            // Read age as a string, parse it to int, and validate it

            Console.Write("Enter your age: ");

            string input = Console.ReadLine();

            try
            {
                int userAge = int.Parse(input);

                if (userAge > 0)
                {
                    Console.WriteLine("Valid age.");
                }
                else
                {
                    Console.WriteLine("Invalid age.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a number.");
            }


            // Q10
            // Demonstrating prefix and postfix increment

            int q10X = 5;

            int prefixResult = ++q10X;

            Console.WriteLine("Prefix result: " + prefixResult);
            Console.WriteLine("X after prefix: " + q10X);

            q10X = 5;

            int postfixResult = q10X++;

            Console.WriteLine("Postfix result: " + postfixResult);
            Console.WriteLine("X after postfix: " + q10X);


            // Q11
            // Demonstrating prefix and postfix in the same expression

            int q11X = 5;

            int q11Y = ++q11X + q11X++;

            Console.WriteLine("X = " + q11X);
            Console.WriteLine("Y = " + q11Y);
        }



            // Class used in Q4

    class Person
        {
            public string Name;
        }


    }
    }

