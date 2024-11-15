using System;
using System.Net.WebSockets;
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
        Console.WriteLine("Please choose a function \nTo see a list of all functions, please type 'list'\nTo exit the program, please type 'End'");
        var response = Console.ReadLine();
        if (response == "list")
        {
            Console.WriteLine("Sum\nConvert\nPlusOne\nCircuitPower\nCalcAge\ntriArea\nnegativity\nlessThan100\nsomething\nReverse" +
                "\nhowManySeconds\nSumPolygon");
            Start();
        }
        else if (response == "Sum")
        {
            Console.WriteLine("We are going to use number adder today called 'Sum.' Please give me the first number.");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine("Please give me the second number.");
            var number2 = Console.ReadLine();
            int numberToUse2 = int.Parse(number2);
            Console.WriteLine("The sum of the number " + number1 + " and " + number2 + " is " + Sum(numberToUse1, numberToUse2) + ".");
        }
        else if (response == "Convert")
        {
            Console.WriteLine("We are going to use the minute to second convertor today called 'Convert.' \nPlease give me a number of minutes to convert to seconds.");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine(number1 + " minutes is equivalent to " + Convert(numberToUse1) + " seconds.");
        }
        else if (response == "PlusOne")
        {
            Console.WriteLine("We are going to use the number incrementer today called 'PlusOne.' \nPlease give me a number to increment.");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine(number1 + " + 1 = " + PlusOne(numberToUse1) + ".");

        }
        else if (response == "CircuitPower")
        {
            Console.WriteLine("We are going to use the power calculator called 'CircuitPower.' \nPlease give me the voltage.");
            var voltage = Console.ReadLine();
            int voltageInt = int.Parse(voltage);
            Console.WriteLine("Now please give me the current.");
            var current = Console.ReadLine();
            int currentInt = int.Parse(current);
            Console.WriteLine("With the voltage of " + voltage + " and the current of " + current + ", the circuit power will be " + CircuitPower(voltageInt, currentInt) + ".");
        }
        else if (response == "CalcAge")
        {
            Console.WriteLine("We are going to the year to day converter called 'CalcAge.' \nPlease give me the years");
            var years = Console.ReadLine();
            var yearsInt = int.Parse(years);
            Console.WriteLine(years + " years converted to days is " + CalcAge(yearsInt) + ".");
        }
        else if (response == "triArea")
        {
            Console.WriteLine("We are going to use the triangle are calculator called 'triArea.' Please give me the base.");
            var number1 = Console.ReadLine();
            float numberToUse1 = float.Parse(number1);
            Console.WriteLine("Please give me the height.");
            var number2 = Console.ReadLine();
            float numberToUse2 = float.Parse(number2);
            Console.WriteLine("The area of a triangle with the base " + number1 + " and height " + number2 + " is " + triArea(numberToUse1, numberToUse2) + ".");
        }
        else if (response == "negativity")
        {
            Console.WriteLine("Today we are going to use the negativity checker called 'negativity.' \nKeep in mind the function will return true even if the number is 0, which is neither.");
            var number1 = Console.ReadLine();
            float numberToUse1 = float.Parse(number1);
            Console.WriteLine(lessThanOrEqualToZero(numberToUse1));
        }
        else if (response == "lessThan100")
        {
            Console.WriteLine("Today we are going to use the sum value checker called 'lessThan100'\nPlease give me the first number to add.");
            var number1 = Console.ReadLine();
            float numberToUse1 = float.Parse(number1);
            Console.WriteLine("Now give me the second number to add.");
            var number2 = Console.ReadLine();
            float numberToUse2 = float.Parse(number2);
            Console.WriteLine(lessThan100(numberToUse1, numberToUse2));
            if (lessThan100(numberToUse1, numberToUse2))
            {
                Console.WriteLine((numberToUse1 + numberToUse2) + " is less than 100.");
            }
            else
            {
                Console.WriteLine((numberToUse1 + numberToUse2) + " is greater than 100.");
            }

        }
        else if (response == "isEqual")
        {
            Console.WriteLine("Today we are going to use the equality checker called 'isEqual.' \nPlease give me a number.");
            var number1 = Console.ReadLine();
            int numberToUse1 = int.Parse(number1);
            Console.WriteLine("Now please give me another number");
            var number2 = Console.ReadLine();
            int numberToUse2 = int.Parse((number2));
            Console.WriteLine(isEqual(numberToUse1, numberToUse2));
            if (isEqual(numberToUse1, numberToUse2))
            {
                Console.WriteLine(number1 + " and " + number2 + " are equal.");
            }
            else
            {
                Console.WriteLine(number1 + " and " + number2 + " are not equal.");

            }
        }
        else if (response == "something")
        {
            Console.WriteLine("Today we are going to use the something called 'something.' \nPlease say something.");
            string responseH = Console.ReadLine();
            
            Console.WriteLine(something(responseH));
        }
        else if (response == "Reverse")
        {
            Console.WriteLine("Today we are going to use the reverser. \nPlease choose either 'true' or 'false.'");
            var responseh = Console.ReadLine();
            bool responseToUse = bool.Parse(responseh);
            Console.WriteLine("The opposite of " + responseh + " is " + Reverse(responseToUse) + ".");
        }
        else if (response == "howManySeconds")
        {
            Console.WriteLine("Today we are going to use the hour to second converter called 'howManySeconds.'\nPlease give me the number of hours.");
            var hours = Console.ReadLine();
            float hoursToUse = float.Parse(hours);
            Console.WriteLine(hours + " hours is equal to " + howManySeconds(hoursToUse) + " seconds.");
        }
        else if (response == "SumPolygon")
        {
            Console.WriteLine("Today we are going to use the sum of internal angle calculator called 'SumPolygon.'\nPlease give me the number of sides the polygon has.");
            bool validNumber = false;
            while (!validNumber)
            {
                var Inputsides = Console.ReadLine();
                if (int.TryParse(Inputsides, out _))
                {
                    int sides = int.Parse(Inputsides);
                    if (sides < 3)
                    {
                        Console.WriteLine("A polygon can't have " + Inputsides + " sides.\nPlease give me a polygon.");
                    }
                    else
                    {
                        validNumber = true;
                        Console.WriteLine("The sum of all internal angles of a polygon with " + Inputsides + " sides is " + SumPolygon(sides) + " degrees.");

                    }
                }
                else
                {
                    Console.WriteLine("That isn't a valid input.");
                }
            }
            
        }
        else if (response == "End")
        {
            return;
        }
        else
        {
            Console.WriteLine("That is not a valid function.");

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
        return ("something " + input);
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
}
