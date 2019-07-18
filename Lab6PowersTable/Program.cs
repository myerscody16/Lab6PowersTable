using System;

namespace Lab6PowersTable
{
    class Program
    {
        static void Main(string[] args)
        {
            bool valid = true;
            while (valid)
            {
                double userNum = ValidateIntegers("Please type an integer and press enter.");
                Console.WriteLine("Number" + "\t" + "Squared" + "\t" + "Cubed");
                Console.WriteLine("======" + "\t" + "=======" + "\t" + "=====");
                //use a for loop for every i up to the userNum the initial number is printed as i, the squred method is 
                //run returning a value which is printed
                //and then the cubed method is run and then printed into a final writeline 
                //statement that formats them all in line. this repeats up to userNum.
                for(int i = 1; i > userNum; i++)
                {
                    double sqNumber = FindSquares(userNum);
                    double cbNumber = FindCubes(userNum);
                    Console.WriteLine($"{i}     " + "\t"+ $"{sqNumber}       " + "\t" + $"{cbNumber}    ");
                }
                
                bool cont2 = true;
                while (cont2)
                {
                    Console.WriteLine("Would you like to run this again? Enter y or n and press enter");
                    string usrDec = Console.ReadLine().ToLower();
                    if (usrDec == "y")
                    {
                        break;
                    }
                    else if (usrDec == "n")
                    {
                        Console.WriteLine("Goodbye.");
                        System.Environment.Exit(0);
                    }
                    else
                    {
                        Console.WriteLine("Invalid response, please try again.");
                        continue;
                    }
                }
                continue;
            }

        }
        public static int ValidateIntegers(string message)
        {
            string input = GetUserInput(message);
            int number;
            if (int.TryParse(input, out number))
            {
                return number;
            }
            else
            {
                return ValidateIntegers("Please input a correct number!");
            }
        }
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return input;
        }
        public static double FindSquares(double userNum)
        {
            double sqNum = Math.Pow(userNum, 2);
            return sqNum;
        }
        public static double FindCubes(double userNum)
        {
                double cbNum = Math.Pow(userNum, 3);
                return cbNum;
        }
    }
}
