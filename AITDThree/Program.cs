using System;

namespace AITDThree
{
    internal class Program
    {

        /// <summary>
        /// This program discusses value and reference types.
        /// </summary>
        /// <author>
        /// Samuel Bancroft (c) 2017
        /// </author>
        /// <code>
        /// Made up of one main file
        /// Program.cs => the main file
        /// </code>

        private static void Main(string[] args)
        {
            // Value types are immutable i.e. they cannot be changed
            var date = new DateTime(2017, 05, 19);
            // The DateTime value type date is now set to 19th May 2017, you can of course give the variable another value, but you cannot change the value of "19th May 2017"
            var dateTime = date.AddDays(1);
            // the AddDays() function of DateTime will add day(s) but date remains the same and will need to be put into another variable to be made permanent
            Console.WriteLine("The DateTime variable date holds: " + date);
            Console.WriteLine("date + 1 using the AddDays() method is:  " + date.AddDays(1));
            Console.WriteLine("date is still: " + date + " even after running the AddDays() function on it.");
            var newDate = date.AddDays(1);
            Console.WriteLine("To make a new variable holding a date + 1 day you must do; var newDate = date.AddDays(1) so newDate is: " + newDate);

            // Strings are reference type but have some properties akin to value types. The Trim() function is one.
            var test = " spaces ";
            Console.WriteLine(test + ": before Trim()");
            test.Trim();
            Console.WriteLine(test + ": after Trim()");
            var test2 = test.Trim();
            Console.WriteLine(test2 + ": a new variable called test2 now holds the result of test.Trim()");
            Console.WriteLine("You could also keep the original variable by declaring test = test.Trim()");

            Console.ReadKey();
        }
    }
}
