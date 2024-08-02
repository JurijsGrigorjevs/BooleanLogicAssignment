using System;


namespace BooleanLogicAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Car Insurance Application");
            Console.WriteLine("What is your age?");
            // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Have you ever had a DUI? (YES or NO)");
            // Returns a copy of this string converted to uppercase.
            string answer = Console.ReadLine().ToUpper();
            // The answer should be (equal (==)) - YES
            bool dui = answer == "YES";
            Console.WriteLine("How many speeding tickets do you have?");
            // Converts the string representation of a number to its 32-bit signed integer equivalent. A return value indicates whether the conversion succeeded
            int tickets = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Qualified for insurance?");
            // Criteria for insurance - age over 15 years AND no DUI AND tickets 3 or less 3
            bool qualified = (age > 15) && !dui && (tickets <= 3);
            Console.WriteLine(qualified);



            string name = "Joe";

            if (name != "Jesse")
            {
                Console.WriteLine("Your name is Jesse");
            }
            else if (name == "Brett")
            {
                Console.WriteLine("Your name is not Jesse");
            }
            else if (name == "Joe")
            {
                Console.WriteLine("Your name is Adam");
            }
            else if (name == "Joe")
            {
                Console.WriteLine("Joe");
            }



            int num1 = 18;
            int num2 = 14;
            int num3 = 21;
            int num4 = 13;

            if (num1 > num2 && num3 < num2)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num2 < num3 || num4 > num1)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num3 > num1 && num1 < num2)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num4 != num2 && num2 > num3)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();


            int num11 = 18;
            int num12 = 14;
            int num13 = 21;
            int num14 = 13;

            if (num11 > num12)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num12 < num13)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num13 > num11)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num14 < num12)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();

            int num21 = 19;
            int num22 = 14;
            int num23 = 14;
            int num24 = 18;

            if (num21 > num22 && num23 < num22)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num22 != num23 || num24 > num21)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num23 < num21 && num21 > num22)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num24 < num22 && num22 < num23)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();

            int num31 = 18;
            int num32 = 14;
            int num33 = 21;
            int num34 = 13;

            if (num31 > num32 && num33 < num32)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num32 < num33 || num34 > num31)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num33 > num31 && num31 < num32)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num34 != num32 && num32 > num33)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();

            int num41 = 18;
            int num42 = 14;
            int num43 = 21;
            int num44 = 13;

            if (num41 > num42)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num42 < num43)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num43 > num41)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num44 < num42)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();

            int num51 = 18;
            int num52 = 14;
            int num53 = 21;
            int num54 = 13;

            if (num51 > num52)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num52 < num53)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num53 > num51)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num54 < num52)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();

            int num61 = 5;
            int num62 = 2;
            int num63 = 8;
            int num64 = 6;

            if (num61 < num62)
            {
                Console.WriteLine("Statement 1");
            }
            else if (num62 > num63)
            {
                Console.WriteLine("Statement 2");
            }
            else if (num63 < num61)
            {
                Console.WriteLine("Statement 3");
            }
            else if (num64 > num62)
            {
                Console.WriteLine("Statement 4");
            }
            Console.ReadLine();

            int num71 = 7;
            int num72 = 12;

            string result = num71 > num72 ? "num1 is greater" : "num1 is not greater";
            Console.WriteLine(result);

        }
    }
}
