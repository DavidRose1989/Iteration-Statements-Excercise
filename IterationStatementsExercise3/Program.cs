namespace IterationStatementsExercise3
{
    internal class Program
    {

        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Print1000()
        {
            for (int i = 1000; i >= -1000; i--)
            {
                Console.WriteLine(i);
            }
        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time

        public static void Print3999()
        {
            for (int i = 3; i <= 999; i += 3)
            { Console.WriteLine(i); }

        }

        //Write a method to accept two integers as parameterss and check whether they are equal or not

        public static void Equal(int num1, int num2)
        {
            if (num1 == num2)
            {
                Console.WriteLine($"{num1} is equal to {num2}");
            }
            else
            {
                Console.WriteLine($"{num1} is not equal to {num2}");

            }

        }

        //Write a method to check whether a given number is even or odd

        public static void EvenorOdd(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is even");
            }
            else
            {
                Console.WriteLine($"{num} is odd");

            }
        }

        //Write a method to check whether a given number is positive or negative

        public static void PosorNeg(int num)
        {
            if (num >= 0)
            {
                Console.WriteLine($"{num} is positive");
            }
            else
            {
                Console.WriteLine($"{num} is negative");
            }

        }

        //Write a method to read the age of a candidate and determine whether they can vote.

        public static void Vote()
        {
            var num = int.Parse(Console.ReadLine());                                    //Hint: Use Parse or the safer TryParse() for an extra challenge
                                                                                        //Parse()
            if (num >= 18)                                                              //TryParse()
            {
                Console.WriteLine($"Candidate is {num}, so they can vote");
            }
            else
            {
                Console.WriteLine($"Candidate is {num}, so they can't vote");
            }


        }



        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10

        public static void Range()
        {
            Console.WriteLine("Enter a number");

            var answer = int.Parse(Console.ReadLine());

            if (answer >= -10 && answer <= 10)
            {
                Console.WriteLine("You are within range");
            }
            else
            {
                Console.WriteLine("I'm sorry but you're not within range");
            }
        }



        //Write a method to display the multiplication table(from 1 to 12) of a given integer

        public static void Displaytable(int num3)
        {
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine($" {i} x {num3} = {i} x {num3}");

            }

        }


        //Call the methods to test them in the Main method below

        static void Main(string[] args)
        {
            Console.WriteLine("All numbers 1000 though -1000");
            Print1000();

            Console.WriteLine("Numbers 3 through 999 counting by 3");
            Print3999();

            Console.WriteLine("Are they equal?");
            Equal(40, 40);

            Console.WriteLine("The following number will be even or odd");
            EvenorOdd(60);

            Console.WriteLine("The following number will be positive or negative");
            PosorNeg(60);

            Console.WriteLine("Are you old enough to vote");
            Vote();

            Console.WriteLine("Are you within range");
            Range();

            Displaytable(5);
        }

    }
}