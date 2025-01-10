namespace LAB_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Zadanie 1 
            Console.WriteLine("Zmienne i typy danych");
            byte byteVariable = 50;
            int integralVariable = 300;
            long longVariable = 100000000;
            char charVariable1 = (char)87;
            char charVariable2 = 'a';
            double doubleVariable = 50.0005;
            float floatVariable = 50e10F;
            string stringVariable = "How you doing?";

            Console.WriteLine(byteVariable);
            Console.WriteLine(integralVariable);
            Console.WriteLine(longVariable);
            Console.WriteLine(charVariable1);
            Console.WriteLine(charVariable2);
            Console.WriteLine(doubleVariable);
            Console.WriteLine(floatVariable);
            Console.WriteLine(stringVariable);

            // Zadanie 2
            int num = 2147483647;
            long bigNum = 88888888888;
            string stringNum = "1024";

            long num2 = num;
            int bigNum2 = (int)bigNum;
            int stringNum2 = int.Parse(stringNum);
            Console.WriteLine(num2);
            Console.WriteLine(bigNum2);
            Console.WriteLine(stringNum2);

            // Zadanie 3
            int a = 18;
            int b = 6;
            decimal price = 10.56m;
            double doubleVal = 10.56;
            double radius = 5.0;
            double time = 1234.45;
            int c = a + b;
            int d = a - b;
            int e = a * b;
            int f = a / b;
            int g = a % b;
            Console.WriteLine($"{c} {d} {e} {f} {g}");
            Console.WriteLine(price * price);
            Console.WriteLine(doubleVal * doubleVal);
            Console.WriteLine(Math.PI * radius * radius);

            double hours = time / 60;
            double minutes = time;
            double seconds = time * 60;
            Console.WriteLine($"hours: {hours}, minutes: {minutes}, seconds: {seconds}");

            // Zadanie 4
            int toIncrement = 3;
            int toDivide = 5;
            toIncrement++;
            toDivide /= toDivide;
            Console.WriteLine($"toIncrecement: {toIncrement}, toDivide: {toDivide}");

            // Zadanie 5
            double degree = 45;
            double sinValue;
            sinValue = Math.Sin(degree);
            Console.WriteLine(sinValue);

            // Zadanie 6
            int year = 2024;
            int month = 5;
            int day = 3;
            int hour = 23;
            int minute = 30;
            DateTime dateTime = new DateTime(year, month, day, hour, minute, 0);
            dateTime = dateTime.AddMonths(3); dateTime = dateTime.AddHours(-1);
            Console.WriteLine(dateTime.DayOfWeek);

            // Zadanie 7
            string firstPart = "This is";
            string secondPart = "a string";
            string thirdPart = "with capital letters.";

            string text = firstPart + " " + secondPart + " " + thirdPart;
            Console.WriteLine($"{text.ToUpper()} {text.Length}");

            // Zadanie 8
            double lengthA = 5;
            double lengthB = 1;
            double lengthC = 3;

            bool ifTriangle = false;
            bool ifRight = false;

            if (lengthA + lengthB > lengthC && lengthA + lengthC > lengthB && lengthB + lengthC > lengthA)
            {
                ifTriangle = true;
                if (Math.Pow(lengthA, 2) + Math.Pow(lengthB, 2) == Math.Pow(lengthC, 2) ||
                    Math.Pow(lengthA, 2) + Math.Pow(lengthC, 2) == Math.Pow(lengthB, 2) ||
                    Math.Pow(lengthB, 2) + Math.Pow(lengthC, 2) == Math.Pow(lengthA, 2))
                {
                    ifRight = true;
                }
                else
                {
                    ifRight = false;
                }
            }
            else
            {
                ifTriangle = false;
            }
            Console.WriteLine($"{ifTriangle}, {ifRight}");

            // Zadanie 9
            string conditionalString = "To be or not to be?";
            if (conditionalString.Length > 10)
            {
                Console.WriteLine(conditionalString);
            }

            // Zadanie 10
            int temperature = 22;
            if (temperature > 20)
            {
                Console.WriteLine("ciepło");
            }
            else
            {
                Console.WriteLine("zimno");
            }

            // Zadanie 11
            string result = temperature > 20 ? "ciepło" : "zimno";
            Console.WriteLine(result);

            // Zadanie 12
            int code = 4;
            int quantity = 11;
            decimal productPrice = 3.5m;
            decimal sellPrice;
            if (code < 10)
            {
                sellPrice = productPrice;
            }
            else if (code >= 10 && code <= 15)
            {
                sellPrice = productPrice - (productPrice / 100 * 5);
            }
            else
            {
                if (quantity <= 10)
                {
                    sellPrice = productPrice + (productPrice / 100 * 5);
                }
                else if (quantity > 10 && quantity <= 20)
                {
                    sellPrice = productPrice;
                }
                else if (quantity > 20 && quantity <= 100)
                {
                    sellPrice = productPrice - ((productPrice / 100) * (quantity / 10));
                }
                else
                {
                    sellPrice = productPrice - productPrice / 10;
                }
            }
            Console.WriteLine($"Price: {sellPrice}");

            // Zadanie 13
            char hexNum = 'E';
            switch (hexNum)
            {
                case '0':
                    Console.WriteLine($"Decimal number: 0");
                    break;
                case '1':
                    Console.WriteLine($"Decimal number: 1");
                    break;
                case '2':
                    Console.WriteLine($"Decimal number: 2");
                    break;
                case '3':
                    Console.WriteLine($"Decimal number: 3");
                    break;
                case '4':
                    Console.WriteLine($"Decimal number: 4");
                    break;
                case '5':
                    Console.WriteLine($"Decimal number: 5");
                    break;
                case '6':
                    Console.WriteLine($"Decimal number: 6");
                    break;
                case '7':
                    Console.WriteLine($"Decimal number: 7");
                    break;
                case '8':
                    Console.WriteLine($"Decimal number: 8");
                    break;
                case '9':
                    Console.WriteLine($"Decimal number: 9");
                    break;
                case 'A':
                    Console.WriteLine($"Decimal number: 10");
                    break;
                case 'B':
                    Console.WriteLine($"Decimal number: 11");
                    break;
                case 'C':
                    Console.WriteLine($"Decimal number: 12");
                    break;
                case 'D':
                    Console.WriteLine($"Decimal number: 13");
                    break;
                case 'E':
                    Console.WriteLine($"Decimal number: 14");
                    break;
                case 'F':
                    Console.WriteLine($"Decimal number: 15");
                    break;
                default:
                    Console.WriteLine($"Not a valid hexadecimal number!");
                    break;
            }
        }
    }
}
