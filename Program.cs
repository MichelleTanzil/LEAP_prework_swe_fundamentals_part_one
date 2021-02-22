using System;

namespace HelloWorld
{
    /// <summary>
    ///  This class performs an important function.
    /// </summary>
    public enum Mood
    {
        Undefined,
        Hungry,
        Sleepy = 50,
        Grumpy = 10,
        Happy = 2
    }

    public struct Book
    {
        public decimal price;
        public string title;
        public string author;
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            //write hello to the console
            Console.WriteLine("Hello World");
            Console.ReadKey();

            //Single line comment
            /*
                * A multi-line
                * comment block
            */

            bool isTrue;
            int value;
            double deci;
            char character;
            string sentence;

            isTrue = true;
            value = 27;
            deci = 5.1;
            character = 'm';
            sentence = "My name is Michelle";

            Console.WriteLine($"Hi, {sentence}. I'm {value} years old and {deci} tall.");
            Console.WriteLine($"My first name initial is {character} and it's {isTrue} that it's me.");

            int maxValue = int.MaxValue;
            maxValue++;
            Console.WriteLine("Max: " + maxValue);

            var isFalse = false;
            var number = 28;
            var doubleNumber = 7.5;
            var charac = 't';
            var catSound = "meow";

            int x = 10, y = 20;
            int z1 = x++;
            int z2 = ++y;
            Console.WriteLine($"x is {x}, y is {y}, z1 is {z1}, and z2 is {z2}");

            int z = 30;
            int a = x + y;
            int b = z - x;
            int c = x * y;
            bool isXEven = x % 2 == 0 ? true : false;
            bool isYDivisibleBy3 = y % 3 == 0 ? true : false;
            decimal threeDecimalPlaces = 12.898999m;
            threeDecimalPlaces = Math.Truncate(threeDecimalPlaces * 1000m) / 1000m;

            double threeDecimalPlacesOther = 12.898999;
            threeDecimalPlacesOther = Math.Round(threeDecimalPlacesOther, 3);

            Console.WriteLine("isXEven: " + isXEven);
            Console.WriteLine("isYDivisibleBy3: " + isYDivisibleBy3);
            Console.WriteLine("threeDecimalPlaces: " + threeDecimalPlaces);
            Console.WriteLine("threeDecimalPlacesOther: " + threeDecimalPlacesOther);

            double d = 5.0, e = 5.1, f = 5.2;
            int m, n, o;

            m = (int)d;
            n = (int)e;
            o = (int)f;
            d = x;
            e = y;
            f = z;

            Console.WriteLine("d: " + d);
            Console.WriteLine("e: " + e);
            Console.WriteLine("f: " + f);
            Console.WriteLine("x: " + x);
            Console.WriteLine("y: " + y);
            Console.WriteLine("z: " + z);

            string escapedString = "Here's a line break: \n";
            string literalString = @"c:\Home\FileName";
            string combinedString = "This is a " + "combined string.";

            Console.WriteLine(escapedString);
            Console.WriteLine(literalString);
            Console.WriteLine(combinedString);
            Console.WriteLine("The length of the combined string: " + combinedString.Length);

            string str = "Blahb";
            Console.WriteLine($"{str[0]} {str[2]} {str[str.Length - 1]}");
            string str1 = str.Substring(0, 2);
            Console.WriteLine(str1);
            Console.WriteLine(str.ToUpper());
            Console.WriteLine(str.ToLower());

            string str2 = "Meow Meow!";
            string str3 = str2.Substring(1, str2.Length - 2);
            Console.WriteLine(str3);
            string str4 = str2.Replace('M', 'm');
            Console.WriteLine(str4);

            string xStr = "meow meow meow";
            char yChar = 'm';
            Console.WriteLine(xStr.IndexOf(yChar));
            Console.WriteLine(xStr.Contains(yChar));
            string filePath = @"c:\foo\bar.txt";
            int firstIndex = filePath.LastIndexOf('\\');
            int lastIndex = filePath.IndexOf(".txt");
            string result = filePath.Substring(firstIndex + 1, lastIndex - firstIndex - 1);
            Console.WriteLine(result);
            int barFirstIndex = filePath.IndexOf('\\');
            string resultDrive = filePath.Substring(0, barFirstIndex);
            Console.WriteLine(resultDrive.ToUpper());

            string splitting = "meow meow";
            Console.WriteLine(splitting.Split(' '));

            const string formatString = "Hello {0}! It's {1} and it's a lovely {2}. The time is {3}";
            const string name = "Michelle";
            const string dayOfWeek = "Friday";
            const string word = "day";

            string str5 = string.Format(formatString, name, dayOfWeek, word, DateTime.Now.ToShortTimeString());
            Console.WriteLine(str5);

            double formatDouble = 3.1493745;
            string str6 = $"{formatDouble:0.00}";
            Console.WriteLine(str6);

            bool printA = true;
            int printB = 5;
            double printC = 5.5;
            char printD = 'd';

            string printW = printA.ToString();
            string printX = printB.ToString();
            string printY = printC.ToString();
            string printZ = printD.ToString();

            bool printE = bool.Parse(printW);
            int printF = int.Parse(printX);
            double printG = double.Parse(printY);
            char printH = char.Parse(printZ);
            Console.WriteLine(printE);
            Console.WriteLine(printF);
            Console.WriteLine(printG);
            Console.WriteLine(printH);

            int verySleepy = (int)Mood.Sleepy;
            Console.WriteLine($"{Mood.Sleepy.ToString()}: {verySleepy}");

            var secondBook = new Book();
            secondBook.title = "Harry Potter";
            secondBook.author = "J. K. Rowling";
            secondBook.price = 5.99m;

            var firstBook = new Book();
            firstBook.title = secondBook.title;
            firstBook.author = secondBook.author;
            firstBook.price = secondBook.price;

            Console.WriteLine("firstBook.title: " + firstBook.title);
            Console.WriteLine("firstBook.author: " + firstBook.author);
            Console.WriteLine("firstBook.price: " + firstBook.price);

            Console.WriteLine("Enter your first name: ");
            Console.ReadLine();
            Console.WriteLine("Enter your middle initial: ");
            Console.ReadLine();
            Console.WriteLine("Enter your last name: ");
            Console.ReadLine();
            Console.WriteLine("Press any key to exit... ");
            Console.ReadKey();

            bool isValid = true;
            foreach (string s in args)
            {
                if (s == "/?")
                {
                    isValid = false;
                }
            }
            DirectionProgram example = new DirectionProgram();

            if (args.Length > 0 && args.Length < 2)
            {
                Console.WriteLine("The first two arguments must be included.");
            }
            else if (args.Length == 0)
            {
                Console.WriteLine("The arguments expected are a direction (Up, Down, Left, or Right), boolean (true or false), and an integer value");
            }
            else if (isValid == false)
            {
                Console.WriteLine("The arguments expected are a direction (Up, Down, Left, or Right), boolean (true or false), and an integer value");
            }
            else if (args.Length == 2)
            {
                example.DirectionProgramMethod(args[0], args[1]);
            }
            else
            {
                example.DirectionProgramMethod(args[0], args[1], args[2]);
            }

            //Command Line Arguments
            //C: \Users\goodvibes\source\repos\HelloWorld\HelloWorld\bin\Debug\netcoreapp3.1 > HelloWorld.exe Down False 15
            //realDirection: Down
            //isTrue: False
            //val: 15
        }
    }

    internal class DirectionProgram
    {
        public void DirectionProgramMethod(string direction, string boolean, string value = "5")
        {
            try
            {
                var isDirection = Enum.IsDefined(typeof(Direction), direction);
                if (isDirection)
                {
                    var realDirection = Enum.Parse(typeof(Direction), direction, true);
                    Console.WriteLine("realDirection: " + realDirection);
                }
                else
                {
                    Console.WriteLine("Unable to convert '{0}'.", direction);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}'.", direction);
            }
            try
            {
                bool isTrue = bool.Parse(boolean);
                Console.WriteLine("isTrue: " + isTrue);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}'.", boolean);
            }

            try
            {
                int val = int.Parse(value);
                Console.WriteLine("val: " + val);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert '{0}'.", value);
            }
        }
    }
}