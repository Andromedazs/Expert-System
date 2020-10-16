using System;
using System.Collections.Generic;
#pragma warning disable CS1001 // Identifier expected
using System.Globalization.;
#pragma warning restore CS1001 // Identifier expected
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace Expert_System_V2
{
    //************************************************
    // Application: The Expert System
    // Author: Kage-Weir, Nakiah
    // Description: An application that tells your age 
    //              based on your birthdate.
    // Date Created: 10/08/2020
    //************************************************
    class Program
    {
        private static int second;
        private static int minute;
        private static int hour;
        private static int current_date;
        private static int birth_date;
        private static int current_month;
        private static int current_year;
        private static int birthyear;
        private static int birthmonth;


        static void Main(string[] args)
        {
            //
            // Screen Config
            //
            Console.CursorVisible = true;
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Clear();

            //
            // Greeting
            //
            Console.WriteLine("Hello, My Name is Nakiah. I created this app to calculate your age based on your birthdate!");

            //
            // get username to echo
            //
            Console.WriteLine("What is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("It is nice to meet you " + userName + ".");
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();

            // 
            // Collect info
            //
            Console.WriteLine("Please enter month of birth");
            string month = Console.ReadLine();
            bool choice = false;
            

            do
            {
                switch (month)
                {
                    case "january":
                        int birthmonth = 1;
                        choice = true;
                        break;

                    case "february":
                        int birthmonth = 2;
                        choice = true;
                        break;

                    case "march":
                        int birthmonth = 3;
                        choice = true;
                        break;

                    case "arpil":
                        int birthmonth = 4;
                        choice = true;
                        break;

                    case "may":
                        int birthmonth = 5;
                        choice = true;
                        break;

                    case "june":
                        int birthmonth = 6;
                        choice = true;
                        break;

                    case "july":
                        int birthmonth = 7;
                        choice = true;
                        break;

                    case "august":
                        int birthmonth = 8;
                        choice = true;
                        break;

                    case "september":
                        int birthmonth = 9;
                        choice = true;
                        break;

                    case "october":
                        int birthmonth = 10;
                        choice = true;
                        break;

                    case "november":
                        int birthmonth = 11;
                        choice = true;
                        break;

                    case "december":
                        int birthmonth = 12;
                        choice = true;
                        break;

                    default:
                        Console.WriteLine("I don't know that month.");
                        break;
                }
            } while (!choice);

            Console.WriteLine("Please enter day of birth");
            int.TryParse(Console.ReadLine(), out int day);

            Console.WriteLine("Please enter year of birth");
            int.TryParse(Console.ReadLine(), out int year);

            DateTime dob = new DateTime(year, month: birthmonth, day, hour, minute, second);

            {
                int[] month = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31, };

                //
                // If birthdate is greater then current birth_month, the don't count.
                // Instead add 30 to the date so as to subtract the date and get the
                // remaining days. 
                //
                if (birth_date > current_date)
                {
                    current_month = current_month - 1;

                    current_date = current_date + month[birthmonth - 1];
                }

                //
                // if birth month exceeds current month, then do not count this year.
                // Instead add 12 to the month so we can subtract and find the difference.
                //
                if (birthmonth > current_month)
                {
                    current_year = current_year - 1;

                    current_month = current_month + 12;
                }

                // Calculations 
                int calculated_date = current_date - birth_date;

                int calculated_month = current_month - birthmonth;

                int calculated_year = current_year - birthyear;

                // print current age
                Console.WriteLine("Your current age is:");
                Console.WriteLine("Years: " + calculated_year + "Months: " + calculated_month + "Days: " + calculated_date);
            }
        }

