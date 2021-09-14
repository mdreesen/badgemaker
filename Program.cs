using System;
using System.Collections.Generic;


namespace Catworx.badgeMaker
{
    class Program
    {
        static void Main(string[] args)
        {
            // STRINGS
            // Console.WriteLine("Hello World!");
            // string greeting = "Hello ";
            // greeting = greeting + "World";
            // Console.WriteLine("greeting: " + greeting);
            // Console.WriteLine($"greeting {greeting}");
            // Console.WriteLine("greeting: {0}", greeting);

            // MATH
            // How do you find the area of a square? area = side * side
            // float side = 3.14;
            // double side = 3.14;
            // double area = side * side;
            // Console.WriteLine("area: {0}", area);
            // How do we identify the data type of the variable? We use the "GetType()" function:
            // Console.WriteLine("area is a {0}", area.GetType());

            // Console.WriteLine(2 * 3);         // Basic Arithmetic: +, -, /, * -> 6
            // Console.WriteLine(10 % 3);        // Modulus Op => remainder of 10/3 -> 1
            // Console.WriteLine(1 + 2 * 3);     // order of operations -> 7
            // Console.WriteLine(10 / 3.0);      // int's and doubles -> 3.3333333333333335
            // Console.WriteLine(10 / 3);        // int's -> 3
            // Console.WriteLine("12" + "3");    // What happens here? -> Strings are concatinated -> 123

            // int num = 10;
            // num += 100;
            // Console.WriteLine(num); // -> 110
            // num++;
            // Console.WriteLine(num); // -> 111

            // BOOLEAN
            // bool isCold = true;
            // Console.WriteLine(isCold ? "drink" : "add ice");
            // Console.WriteLine(!isCold ? "drink" : "add ice");

            // CONVERT
            // string stringNum = "2";
            // int intNum = Convert.ToInt16(stringNum);
            // Console.WriteLine(intNum);
            // Console.WriteLine(intNum.GetType());

            // DICTIONARIES
            // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
            //     { "firstInning", 10 },
            //     { "secondInning", 20},
            //     { "thirdInning", 30},
            //     { "fourthInning", 40},
            //     { "fifthInning", 50}
            // };

            // Dictionary<string, int> myScoreBoard = new Dictionary<string, int>();
            // myScoreBoard.Add("firstInning", 10);
            // myScoreBoard.Add("secondInning", 20);
            // myScoreBoard.Add("thirdInning", 30);
            // myScoreBoard.Add("fourthInning", 40);
            // myScoreBoard.Add("fifthInning", 50);

            Dictionary<string, int> myScoreBoard = new Dictionary<string, int>(){
                { "firstInning", 10 },
                { "secondInning", 20},
                { "thirdInning", 30},
                { "fourthInning", 40},
                { "fifthInning", 50}
            };

            Console.WriteLine("----------------");
            Console.WriteLine("  Scoreboard");
            Console.WriteLine("----------------");
            Console.WriteLine("Inning |  Score");
            Console.WriteLine("   1   |    {0}", myScoreBoard["firstInning"]);
            Console.WriteLine("   2   |    {0}", myScoreBoard["secondInning"]);
            Console.WriteLine("   3   |    {0}", myScoreBoard["thirdInning"]);
            Console.WriteLine("   4   |    {0}", myScoreBoard["fourthInning"]);
            Console.WriteLine("   5   |    {0}", myScoreBoard["fifthInning"]);
        }
    }
}
