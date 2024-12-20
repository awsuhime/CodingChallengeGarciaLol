﻿using System;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Runtime.InteropServices;
class Challenges
{
    //Start()
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my coding challenge program. I will be making a variety of functions for you to use.");
        Start();
        
    }

    public static void Start() 
    {
        //Welcome to the user of my program
        Console.WriteLine("    __Please choose a function__ \n    -To see a list of all functions, please type 'list'\n    -To exit the program, please type 'End'");
        var response = Console.ReadLine();
        if (response == "list")
        {
            Console.WriteLine(" Sum\n Convert\n PlusOne\n CircuitPower\n CalcAge\n triArea\n negativity\n lessThan100\n something\n Reverse" +
                "\n howManySeconds\n SumPolygon\n Edabit\n And\n points\n FindPerimeter\n HelloName\n animals \n FootballPoints");
            Start();
        }
        else if (response == "Sum")
        {
            Console.WriteLine(" We are going to use number adder today called 'Sum.' Please give me the first number.");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine(" Please give me the second number.");
            var number2 = Console.ReadLine();
            int numberToUse2 = int.Parse(number2);
            Console.WriteLine(" The sum of the number " + number1 + " and " + number2 + " is " + Sum(numberToUse1, numberToUse2) + ".");
        }
        else if (response == "Convert")
        {
            Console.WriteLine(" We are going to use the minute to second convertor today called 'Convert.' \n Please give me a number of minutes to convert to seconds.");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine(" " + number1 + " minutes is equivalent to " + Convert(numberToUse1) + " seconds.");
        }
        else if (response == "PlusOne")
        {
            Console.WriteLine(" We are going to use the number incrementer today called 'PlusOne.' \n Please give me a number to increment.");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine(" " + number1 + " + 1 = " + PlusOne(numberToUse1) + ".");

        }
        else if (response == "CircuitPower")
        {
            Console.WriteLine(" We are going to use the power calculator called 'CircuitPower.' \n Please give me the voltage.");
            var voltage = Console.ReadLine();
            int voltageInt = int.Parse(voltage);
            Console.WriteLine(" Now please give me the current.");
            var current = Console.ReadLine();
            int currentInt = int.Parse(current);
            Console.WriteLine(" With the voltage of " + voltage + " and the current of " + current + ", the circuit power will be " + CircuitPower(voltageInt, currentInt) + ".");
        }
        else if (response == "CalcAge")
        {
            Console.WriteLine(" We are going to the year to day converter called 'CalcAge.' \nPlease give me the years");
            var years = Console.ReadLine();
            var yearsInt = int.Parse(years);
            Console.WriteLine(" " + years + " years converted to days is " + CalcAge(yearsInt) + ".");
        }
        else if (response == "triArea")
        {
            Console.WriteLine(" We are going to use the triangle are calculator called 'triArea.' Please give me the base.");
            var number1 = Console.ReadLine();
            float numberToUse1 = float.Parse(number1);
            Console.WriteLine(" Please give me the height.");
            var number2 = Console.ReadLine();
            float numberToUse2 = float.Parse(number2);
            Console.WriteLine(" The area of a triangle with the base " + number1 + " and height " + number2 + " is " + triArea(numberToUse1, numberToUse2) + ".");
        }
        else if (response == "negativity")
        {
            Console.WriteLine(" Today we are going to use the negativity checker called 'negativity.' \n Keep in mind the function will return true even if the number is 0, which is neither.");
            var number1 = Console.ReadLine();
            float numberToUse1 = float.Parse(number1);
            Console.WriteLine(lessThanOrEqualToZero(numberToUse1));
        }
        else if (response == "lessThan100")
        {
            Console.WriteLine(" Today we are going to use the sum value checker called 'lessThan100'\n Please give me the first number to add.");
            var number1 = Console.ReadLine();
            float numberToUse1 = float.Parse(number1);
            Console.WriteLine(" Now give me the second number to add.");
            var number2 = Console.ReadLine();
            float numberToUse2 = float.Parse(number2);
            Console.WriteLine(lessThan100(numberToUse1, numberToUse2));
            if (lessThan100(numberToUse1, numberToUse2))
            {
                Console.WriteLine( " " + (numberToUse1 + numberToUse2) + " is less than 100.");
            }
            else
            {
                Console.WriteLine( " " + (numberToUse1 + numberToUse2) + " is greater than 100.");
            }

        }
        else if (response == "isEqual")
        {
            Console.WriteLine(" Today we are going to use the equality checker called 'isEqual.' \n  Please give me a number.");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine(" Now please give me another number");
            var number2 = Console.ReadLine();
            int numberToUse2 = int.Parse((number2));
            Console.WriteLine(isEqual(numberToUse1, numberToUse2));
            if (isEqual(numberToUse1, numberToUse2))
            {
                Console.WriteLine(" " + number1 + " and " + number2 + " are equal.");
            }
            else
            {
                Console.WriteLine(" " + number1 + " and " + number2 + " are not equal.");

            }
        }
        else if (response == "something")
        {
            Console.WriteLine(" Today we are going to use the something called 'something.' \n Please say something.");
            string responseH = Console.ReadLine();
            
            Console.WriteLine(something(responseH));
        }
        else if (response == "Reverse")
        {
            Console.WriteLine(" Today we are going to use the reverser. \n Please choose either 'true' or 'false.'");
            var responseh = Console.ReadLine();
            bool responseToUse = bool.Parse(responseh);
            Console.WriteLine(" The opposite of " + responseh + " is " + Reverse(responseToUse) + ".");
        }
        else if (response == "howManySeconds")
        {
            Console.WriteLine("Today we are going to use the hour to second converter called 'howManySeconds.'\n Please give me the number of hours.");
            var hours = Console.ReadLine();
            float hoursToUse = float.Parse(hours);
            Console.WriteLine( " " + hours + " hours is equal to " + howManySeconds(hoursToUse) + " seconds.");
        }
        else if (response == "SumPolygon")
        {
            Console.WriteLine(" Today we are going to use the sum of internal angle calculator called 'SumPolygon.'\n Please give me the number of sides the polygon has.");
            bool validNumber = false;
            while (!validNumber)
            {
                var Inputsides = Console.ReadLine();
                if (int.TryParse(Inputsides, out _))
                {
                    int sides = int.Parse(Inputsides);
                    if (sides < 3)
                    {
                        Console.WriteLine(" A polygon can't have " + Inputsides + " sides.\n Please give me a polygon.");
                    }
                    else
                    {
                        validNumber = true;
                        Console.WriteLine(" The sum of all internal angles of a polygon with " + Inputsides + " sides is " + SumPolygon(sides) + " degrees.");

                    }
                }
                else
                {
                    Console.WriteLine(" That isn't a valid input.");
                }
            }
            
        }
        else if (response == "Edabit")
        {
            Console.WriteLine(" Today we are going to use the Edabit thing called 'Edabit.' \n Please say something.");
            string name = Console.ReadLine();
            Console.WriteLine(Edabit(name));


        }
        else if (response == "And")
        {
            Console.WriteLine(" Today we are going to use the and gate called 'And.' \n For the first input, please say either true or false.");
            bool valid = false;
            bool one = false;
            bool two = false;
            while (!valid)
            {
                var response1 = Console.ReadLine();
                if (bool.TryParse(response1, out _))
                {
                    one = bool.Parse(response1);
                    valid = true;

                }
                else
                {
                    Console.WriteLine(" Please type either true or false.");
                }
            }
            Console.WriteLine(" For the second input, please say either true or false."); 
            bool valid2 = false;
            while (!valid2)
            {
                var response2 = Console.ReadLine();
                if (bool.TryParse(response2, out _))
                {
                    two = bool.Parse(response2);
                    valid2 = true;

                }
                else
                {
                    Console.WriteLine(" Please type either true or false.");
                }
            }
            Console.WriteLine(" And(" + one + ", " + two + ") -> " + And(one,two));

        }

        else if (response == "points")
        {
            Console.WriteLine(" Today we are going to use the point counter called 'points.' \n First, please give me the number of 2 pointers scored.");
            var twoP = Console.ReadLine();
            int twoPI = int.Parse(twoP);
            Console.WriteLine(" Now, please give me the number of 3 pointers scored.");
            var threeP = Console.ReadLine();
            int threePI = int.Parse(threeP);
            Console.WriteLine(" points(" + twoPI + ", " + threePI + ") -> " + points(twoPI, threePI));
        }
        else if(response == "FindPerimeter")
        {
            Console.WriteLine(" Today we are going to use the perimeter calculator called 'FindPerimeter.' \n First, please give me the length of the rectangle.");
            var lengthP = Console.ReadLine();
            float lengthPF = float.Parse(lengthP);
            Console.WriteLine(" Now please give me the width of the rectangle.");
            var widthP = Console.ReadLine();
            float widthPF = float.Parse(widthP);
            Console.WriteLine(" FindPerimeter(" + lengthP + ", " + widthP + ") -> " + FindPerimeter(lengthPF, widthPF)) ;


        }
        else if (response == "HelloName")
        {
            Console.WriteLine(" Today we are going to use the greet machine called 'HelloName.' \n Please give me your name.");
            string name = Console.ReadLine();
            Console.WriteLine(HelloName(name));
        }
        else if (response == "animals")
        {
            Console.WriteLine(" Today we are going to use the leg counter called 'animals.' \n Please give me the number of chickens.");
            int chick = 1;
            int cow = 1;
            int pig = 1;
            bool valid1 = false;
            while (!valid1)
            {
                var chickS = Console.ReadLine();
                if (int.TryParse(chickS, out _))
                {
                    int chickT = int.Parse(chickS);
                    if (chickT >= 0)
                    {
                        valid1 = true;
                        chick = chickT;
                    }
                    else
                    {
                        Console.WriteLine("Please give me a positive number."); 
                    }
                }
                else
                {
                    Console.WriteLine("It's hard to find the legs on " + chickS + " of a chicken.");
                }
            }
            Console.WriteLine("Now give me the number of cows.");
            bool valid2 = false;
            while (!valid2)
            {
                var cowS = Console.ReadLine();
                if (int.TryParse(cowS, out _))
                {
                    int cowT = int.Parse(cowS);
                    if (cowT >= 0)
                    {
                        valid2 = true;
                        cow = cowT;
                    }
                    else
                    {
                        Console.WriteLine("Please give me a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("It's hard to find the legs on " + cowS + " of a cow.");
                }
            }
            Console.WriteLine("Now give me the number of pigs.");
            bool valid3 = false;
            while (!valid3)
            {
                var pigS = Console.ReadLine();
                if (int.TryParse(pigS, out _))
                {
                    int pigT = int.Parse(pigS);
                    if (pigT >= 0)
                    {
                        valid3 = true;
                        pig = pigT;
                    }
                    else
                    {
                        Console.WriteLine("Please give me a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine("It's hard to find the legs on " + pigS + " of a pig.");
                }
            }

            
            Console.WriteLine(" In total, there are " + animals(chick, cow, pig) + " legs.");

        }
        else if (response == "FootballPoints")
        {
            Console.WriteLine(" Today we are going to use the football point calculator called 'FootballPoints' \n Please give me the number of wins.");
            int win = 1;
            int draw = 1;
            int loss = 1;
            bool valid1 = false;
            while (!valid1)
            {
                var chickS = Console.ReadLine();
                if (int.TryParse(chickS, out _))
                {
                    int chickT = int.Parse(chickS);
                    if (chickT >= 0)
                    {
                        valid1 = true;
                        win = chickT;
                    }
                    else
                    {
                        Console.WriteLine(" Please give me a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine(" Please give me a full number.");
                    
                }
            }
            Console.WriteLine(" Now give me the number of draws.");
            bool valid2 = false;
            while (!valid2)
            {
                var cowS = Console.ReadLine();
                if (int.TryParse(cowS, out _))
                {
                    int cowT = int.Parse(cowS);
                    if (cowT >= 0)
                    {
                        valid2 = true;
                        draw = cowT;
                    }
                    else
                    {
                        Console.WriteLine(" Please give me a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine(" Please give me a full number.");

                }
            }
            Console.WriteLine(" Now give me the number of losses.");
            bool valid3 = false;
            while (!valid3)
            {
                var pigS = Console.ReadLine();
                if (int.TryParse(pigS, out _))
                {
                    int pigT = int.Parse(pigS);
                    if (pigT >= 0)
                    {
                        valid3 = true;
                        loss = pigT;
                    }
                    else
                    {
                        Console.WriteLine(" Please give me a positive number.");
                    }
                }
                else
                {
                    Console.WriteLine(" Please give me a full number.");

                }
            }

            Console.WriteLine(" FootballPoints(" + win + ", " + draw + ", " + loss + ") -> " + FootballPoints(win, draw, loss));
        }
            

        else if (response == "End")
        {
            return;
        }
        else
        {
            Console.WriteLine(" That is not a valid function.");

        }

        Start();
    }

    
    public static int Sum (int one, int two)
    {
        int result = one + two;
        return result;
    }

    public static int Convert(int minutes)
    {
        return minutes * 60;
    }

    public static int PlusOne (int number)
    {
        return number + 1;
    }

    public static int CircuitPower(int voltage, int current)
    {
        return voltage * current;
    }
    
    public static int CalcAge(int years)
    {
        return years * 365;
    }

    public static float triArea(float baseI, float height)
    {
        return baseI * height / 2.0f;
    }

    public static bool lessThanOrEqualToZero(float value)
    {
        if (value > 0)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public static bool lessThan100(float first, float second)
    {
        if (first + second < 100)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }

    public static bool isEqual(int one, int two)
    {
        if (one == two)
        {
            return true;
        }
        else       
        {
            return false;
        }
    }

    public static string something(string input)
    {
        return (" something " + input);
    }

    public static bool Reverse(bool input)
    {
        return !input;
       
        
    }

    public static float howManySeconds(float hours)
    {
        return hours * 3600;
    }

    public static int SumPolygon(int sides)
    {
        return (sides - 2) * 180;
    }

    public static string Edabit(string input)
    {
        return  " " + input + "Edabit";
    }

    public static bool And(bool one, bool two)
    {
        if (one && two)
        {
            return true;

        }
        else
        {
            return false;
        }
    }

    public static int points(int two, int three)
    {
        return two * 2 + three * 3;
    }

    public static float FindPerimeter(float length, float width)
    {
        return (length + width) * 2;
    }

    public static string HelloName(string input)
    {
        return " Hello " + input + "!";
    }

    public static int animals(int chicks, int cows, int pigs)
    {
        return chicks * 2 + cows * 4 + pigs * 4;
    }

    public static int FootballPoints(int wins, int draws, int losses)
    {
        return wins * 3 + draws;
    }
}
