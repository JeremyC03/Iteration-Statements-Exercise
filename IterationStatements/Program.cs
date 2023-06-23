namespace IterationStatements
{
    public class Program
    {
        //LukeWarm Section: Create methods below
        //Write a method that will print to the console all numbers 1000 through - 1000
        public static void Print()
        {
            int number = 1001;

            while(number > -1000)
            {
                number--;
                Console.WriteLine(number);
            }

        }

        //Write a method that will print to the console numbers 3 through 999 by 3 each time
        public static void MultipleOf3()
        {
            int i;
            int num = 3;

            for(i =1; i <= 333; i++)
            {
                Console.WriteLine(num * i);
            }

        }
        //Write a method to accept two integers as parameterss and check whether they are equal or not
        public static void EqualOrNot()
        {
            Console.WriteLine("\n\nPlease enter two numbers.");
            int input1 = int.Parse(Console.ReadLine());
            int input2 = int.Parse(Console.ReadLine());

            if (input1 == input2)
            {
                Console.WriteLine($"Both {input1} and {input2} are equal.");
            }
            else
            {
                Console.WriteLine($"Neither {input1} or {input2} are equal.");
            }
        }
        //Write a method to check whether a given number is even or odd
        public static void EvenOrOdd()
        {
            Console.WriteLine("\n\nPlease enter a number to see if it is odd or even.");
            int input = int.Parse(Console.ReadLine());

            if(input % 2 == 0)
            {
                Console.WriteLine($"The number {input} is even.");
            }
            else
            {
                Console.WriteLine($"The number {input} is odd.");
            }

        }
        //Write a method to check whether a given number is positive or negative
        public static void PositiveOrNegative()
        {
            Console.WriteLine("\n\nPlease enter a number to see if it is positve or negative.");
            int input = int.Parse(Console.ReadLine());

            if (input > 0)
            {
                Console.WriteLine($"{input} is a positive number.");
            }
            else if (input < 0)
            {
                Console.WriteLine($"{input} is a negative number.");
            }
            else
            {
                Console.WriteLine($"The number {input} is neither positve or negative.");
            }

        }
        //Write a method to read the age of a candidate and determine whether they can vote.
        //Hint: Use Parse or the safer TryParse() for an extra challenge
        //Parse()
        //TryParse()
        public static void VoterAge()
        {
            Console.WriteLine("\n\nPlease enter your age.");
            int age = int.Parse(Console.ReadLine());

            if (age >= 18)
            {
                Console.WriteLine("Congradualations! You are of age to participate in this election.");
            }
            else
            {
                Console.WriteLine("Sorry, but you do not meet the age requirement to vote.");
            }
        }
        //Heatin Up Section:
        //Write a method to check if an integer(from the user) is in the range -10 to 10
        public static void Range()
        {
            Console.WriteLine("\n\nPlease enter a number from -10 to 10.");
            int input = int.Parse(Console.ReadLine());

            if (input >= -10 && input <= 10)
            {
                Console.WriteLine($"The number you entered is {input}. Good job!");
            }
            else if (input < -10)
            {
                Console.WriteLine("That number is too low.");
            }
            else
            {
                Console.WriteLine("That number is too high.");
            }
        }

        //Write a method to display the multiplication table(from 1 to 12) of a given integer
        public static void MultTable()
        {
            Console.WriteLine("\n\nPlease enter a positive number.");
            int i;
            int input = int.Parse(Console.ReadLine());

            for(i = 1; i <= 12; i++)
            {
                Console.WriteLine($"{input} x {i} = {input * i}");
            }

        }

        //Call the methods to test them in the Main method below
        static void Main(string[] args)
        {
            Print(); //Needs work
            MultipleOf3();
            EqualOrNot();
            EvenOrOdd();
            PositiveOrNegative();
            VoterAge();
            Range();
            MultTable();
        }
    }
}
