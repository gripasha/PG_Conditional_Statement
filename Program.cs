using System;

namespace PG_Conditional_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What grade do you expect to get in ISM 4300?");
            Console.WriteLine("Please write your integer (0-100) answer now...");
            try
                // try statement will try to catch input errors here
            {
                string input = Console.ReadLine();
                // read the input
                int grade = int.Parse(input);
                // assign it to "grade" after parsing the input value to integer
                if (grade <= 100 && grade >= 98)
                    // if the grade is between 100 and 98 inclusive, the messages below will display
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is A+");
                }
                else if (grade <= 97 && grade >= 92)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is A");
                }
                else if (grade <= 91 && grade >= 90)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is A-");
                }
                else if (grade <= 89 && grade >= 88)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is B+");
                }
                else if (grade <= 87 && grade >= 82)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is B");
                }
                else if (grade <= 81 && grade >= 80)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is B-");
                }
                else if (grade <= 79 && grade >= 78)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is C+");
                }
                else if (grade <= 77 && grade >= 72)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is C");
                }
                else if (grade <= 71 && grade >= 70)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is C-");
                }
                else if (grade <= 69 && grade >= 68)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is D+");
                }
                else if (grade <= 67 && grade >= 62)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is D");
                }
                else if (grade <= 61 && grade >= 60)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is D-");
                }
                else if (grade <= 59)
                {
                    Console.WriteLine("You have entered " + grade + "% ");
                    Console.WriteLine("Your expected letter grade is F");
                }
                else
                // Everyting that does not fit 0-100 schema outputs these statements below
                {
                    Console.WriteLine("Input Error!" + " You have entered " + grade);
                    Console.WriteLine("Input should be an integer value in a range of 0-100");
                    Console.WriteLine("Press any key to exit the program and to try again...");
                    Console.ReadKey(true);
                }
            }
            catch
            // This catch statement catches input errors like text and not integers 
            {
                Console.WriteLine("Input Error!");
                Console.WriteLine("Input should be an integer value in a range of 0-100");
                Console.WriteLine("Press any key to exit the program and to try again...");
                Console.ReadKey(true);
            }
        }
    }
}
