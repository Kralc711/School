using System;

class Program
{
    static void Main()
    {
        // Ask the user for their grade percentage
        Console.Write("Enter your grade percentage: ");
        double gradePercentage = double.Parse(Console.ReadLine());

        // Determine the letter grade
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // Determine if the user passed the course
        if (gradePercentage >= 70)
        {
            Console.WriteLine($"Congratulations! Your grade is {letter}.");
        }
        else
        {
            Console.WriteLine($"You did not pass the course. Your grade is {letter}. Keep working hard for next time.");
        }

        // Determine the sign (stretch challenge)
        int lastDigit = (int)gradePercentage % 10;
        string sign = "";
        
        if (letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        
        // Handle exceptional cases (A+ and F)
        if (letter == "A" && sign == "+")
        {
            letter = "A+";
            sign = "";
        }
        else if (letter == "F")
        {
            sign = "";
        }

        // Display the letter grade with the sign
        Console.WriteLine($"Your final grade is {letter}{sign}");
    }
}
