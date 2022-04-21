using System;

namespace Csharp1
{
    public class Homework
    {
        public void CheckIfNumberIsEvenOrOdd(int number)
        {
            /* Exercise 1
          * using "if" write a programm that checks whether an integer is greater then zero and even or odd
          * Example:
          * -------------------------------------------------
          * |input   | result                               |
          * |--------|--------------------------------------|
          * |  1     | even                                 |
          * |--------|--------------------------------------|
          * |  2     | odd                                  |
          * |--------|--------------------------------------|
          * | -1     | the value should be greater then zero|
          * -------------------------------------------------
          * 
          */int result = number % 2;
            if (number > 0 && result == 0)
            {
                Console.WriteLine("even");
            }
            else if (number > 0 && result > 0)
            {
                Console.WriteLine("odd");
            }
            else
            {
                Console.WriteLine("the value should be greater then zero");
            }
        }
        public void NumberDivideToFour(int number)
        {
            /* Exercise 2
        * using a ternary operator write a program that print if number divide to 4
        * Example: 
        * --------------------------------------------
        * |input   | result                          |
        * |--------|---------------------------------|
        * |  -4    | The number divide to 4          |
        * |--------|---------------------------------|
        * |   2    | The number doesn't divide to 4  |
        * --------------------------------------------
        */
            string result = (number % 4 == 0) ? number + " This number divide to 4" : number + " This number doesn't divide to 4";
            Console.WriteLine(result);

        }
        public void DayOfWeek(string day)
        {
            /* Exercise 3
             * using "switch" statement write a program that print the number of day of week
             * Example: monday - 1, tuesday - 2 etc. 
             * ---------------------------------------------------------
             * |day           |number                                  |
             * |--------------|----------------------------------------|
             * |monday        |   1                                    |
             * |tuesday       |   2                                    |
             * |wednesday     |   3                                    |
             * |thursday      |   4                                    |
             * |friday        |   5                                    |
             * |saturday      |   6                                    |
             * |sunday        |   7                                    |
             * |default value |Wrong value! Please give a day of a week|
             * ---------------------------------------------------------
             */
             string dayToLowerCase = day.ToLower();
            switch (dayToLowerCase)
            {
                case "Monday":
                    Console.WriteLine("1");
                    break;
                case "Tuesday":
                    Console.WriteLine("2");
                    break;
                case "Wednesday":
                    Console.WriteLine("3");
                    break;
                case "Thursday":
                    Console.WriteLine("4");
                    break;
                case "Friday":
                    Console.WriteLine("5");
                    break;
                case "Saturday":
                    Console.WriteLine("6");
                    break;
                case "Sunday":
                    Console.WriteLine("7");
                    break;
                default:
                    Console.WriteLine("Wrong value! Please give a day of a week");
                    break;
            }
        }
        public void CheckLetterIfVowel(char character)
        {
            /* Exercise 4
             * write a program that will print input character is a vowel, consonant or not a letter
             * Method 1: using a switch case
             * Method 2: using if
             * ---------------------------
             * |input| result            |
             * |-----|-------------------|
             * |  a  | a is a vowel      |
             * |  b  | b is a consonant  |
             * ---------------------------
             */
            /*//Method 1: using a switch case
            char character1 = Char.ToLowerInvariant(character);
            switch (character1)
            {
                case 'a':
                    Console.WriteLine(character1 + " is a vowel.");
                    break;
                case 'e':
                    Console.WriteLine(character1 + " is a vowel.");
                    break;
                case 'i':
                    Console.WriteLine(character1 + " is a vowel.");
                    break;
                case 'o':
                    Console.WriteLine(character1 + " is a vowel.");
                    break;
                case 'u':
                    Console.WriteLine(character1 + " is a vowel.");
                    break;
                case 'b':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'c':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'd':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'f':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'g':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'h':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'j':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'k':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'l':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'm':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'n':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'p':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'q':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'r':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 's':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 't':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'v':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'w':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'x':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'y':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                case 'z':
                    Console.WriteLine(character1 + " is a consonant");
                    break;
                default:
                    Console.WriteLine(character1 + " is not a letter");
                    break;
            }
        }*/

            //Method 2: using if
            char val = Char.ToLowerInvariant(character);
        string val1 = Char.ToString(val);
        string vowelList = "aeiou";
        string consonantList = "bcdfghjklmnpqrstvwxyz";

             if(vowelList.Contains(val1)== true)
                 {
                  Console.WriteLine(character + " is a vowel.");
                 }
                    
              else if(consonantList.Contains(val1)==true) 
                 { 
                  Console.WriteLine(character + " is a consonant");
                 }
               else
{
    Console.WriteLine(character + " is not a letter");
}
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();

            homework.CheckIfNumberIsEvenOrOdd(-11);
            homework.CheckIfNumberIsEvenOrOdd(11);
            homework.CheckIfNumberIsEvenOrOdd(8);
            //---------------------------------------
            homework.NumberDivideToFour(10);
            homework.NumberDivideToFour(16);
            //---------------------------------------
            homework.DayOfWeek("Monday");
            homework.DayOfWeek("Sunday");
            homework.DayOfWeek("some day");
            //---------------------------------------
             homework.CheckLetterIfVowel('p');
             homework.CheckLetterIfVowel('i');

        }
    }
}
