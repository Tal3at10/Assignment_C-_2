
namespace Demo
{ 
class Program
{
        static void Main()
        {
            #region Q1

            
        bool isParsed;
        int n;

        do
        {
            Console.WriteLine("Enter a valid integer:");
            string[] input = Console.ReadLine().Split();
            isParsed = int.TryParse(input[0], out n);

            if (!isParsed)
            {
                Console.WriteLine("Invalid input. Please try again.");
            }
        } while (!isParsed);

        Console.WriteLine($"You entered: {n}");
        #endregion

            #region Q2
        string input;
            int n;
            bool isParsed;

            do
            {
                Console.WriteLine("Enter a numeric value:");
                input = Console.ReadLine();

                isParsed = int.TryParse(input, out n);

                if (!isParsed)
                {
                    Console.WriteLine("The input contains non-numeric characters or is not a valid integer. Please try again.");
                }

            } while (!isParsed);

            Console.WriteLine($"You entered the number: {n}");
      
            #endregion

            #region Q3
            float num1, num2;
            bool isNum1Parsed, isNum2Parsed;

            do
            {
                Console.WriteLine("Enter the first floating-point number:");
                isNum1Parsed = float.TryParse(Console.ReadLine(), out num1);

                if (!isNum1Parsed)
                {
                    Console.WriteLine("Invalid input. Please enter a valid floating-point number.");
                }
            } while (!isNum1Parsed);

            do
            {
                Console.WriteLine("Enter the second floating-point number:");
                isNum2Parsed = float.TryParse(Console.ReadLine(), out num2);

                if (!isNum2Parsed)
                {
                    Console.WriteLine("Invalid input. Please enter a valid floating-point number.");
                }
            } while (!isNum2Parsed);

            float result = num1 + num2;
            Console.WriteLine("Sum: " + result);

            // what will happen :  discrepancies can appear due to floating-point precision, e.g., 3.3000002 instead of 3.3
            #endregion

            #region Q4
            string original;
            do
            {
                Console.WriteLine("Input a string with size > 2:");
                original = Console.ReadLine();

                if (original.Length <= 2)
                {
                    Console.WriteLine("String size must be greater than 2. Please try again.");
                }
            } while (original.Length <= 2);

            string sub = original.Substring(0, 2);
            Console.WriteLine("Extracted substring: " + sub);
            #endregion

            #region Q5
              int a = 10;
              int b = a;

                Console.WriteLine("Before modification:");
                Console.WriteLine($"a = {a}, b = {b}");

                b = 20;

                Console.WriteLine("After modifying b:");
                Console.WriteLine($"a = {a}, b = {b}");
            #endregion

            #region Q6
            class Car
    {
        public string Model;
        public int Year;
    }

    static void Main()
    {
        Car car1 = new Car();
        do
        {
            Console.WriteLine("Enter car1 model:");
            car1.Model = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(car1.Model))
            {
                Console.WriteLine("Model cannot be empty. Please try again.");
            }
        } while (string.IsNullOrWhiteSpace(car1.Model));

        do
        {
            Console.WriteLine("Enter car1 year:");
            if (int.TryParse(Console.ReadLine(), out car1.Year) && car1.Year > 0)
            {
                break;
            }
            Console.WriteLine("Year must be a positive integer. Please try again.");
        } while (true);

        Car car2 = car1;

        Console.WriteLine("Before modifying:");
        Console.WriteLine($"car1: Model = {car1.Model}, Year = {car1.Year}");
        Console.WriteLine($"car2: Model = {car2.Model}, Year = {car2.Year}");
        Console.WriteLine();

        car2.Model = "Honda";
        car2.Year = 2022;

        Console.WriteLine("After modifying:");
        Console.WriteLine($"car1: Model = {car1.Model}, Year = {car1.Year}");
        Console.WriteLine($"car2: Model = {car2.Model}, Year = {car2.Year}");
        #endregion

            #region Q7
        static void Main()
        {
            string s1, s2;

            do
            {
                Console.WriteLine("Enter the first string (non-empty):");
                s1 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s1))
                {
                    Console.WriteLine("First string cannot be empty. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(s1));

            do
            {
                Console.WriteLine("Enter the second string (non-empty):");
                s2 = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(s2))
                {
                    Console.WriteLine("Second string cannot be empty. Please try again.");
                }
            } while (string.IsNullOrWhiteSpace(s2));

            Console.WriteLine("Concatenated string: " + s1 + s2);
            #endregion

            #region Q8
            int principal, rate, time;

            do
            {
                Console.WriteLine("Enter a valid principal amount:");
            } while (!int.TryParse(Console.ReadLine(), out principal) || principal <= 0);

            do
            {
                Console.WriteLine("Enter a valid interest rate:");
            } while (!int.TryParse(Console.ReadLine(), out rate) || rate <= 0);

            do
            {
                Console.WriteLine("Enter a valid time period:");
            } while (!int.TryParse(Console.ReadLine(), out time) || time <= 0);

            long interest = (long)(principal * rate * time) / 100;

            Console.WriteLine($"The simple interest is: {interest}");
            #endregion

            #region Q9
            double height;
            int weight;

            do
            {
                Console.WriteLine("Input height in meters (positive value):");
            } while (!double.TryParse(Console.ReadLine(), out height) || height <= 0);

            do
            {
                Console.WriteLine("Input weight in kg (positive value):");
            } while (!int.TryParse(Console.ReadLine(), out weight) || weight <= 0);

            double BMI = (double)(weight) / (height * height);

            Console.WriteLine($"Your BMI is: {BMI}");
            #endregion

            #region Q10

            int temperature;

            do
            {
                Console.WriteLine("Enter the temperature in degrees:");
            } while (!int.TryParse(Console.ReadLine(), out temperature));

            string result;

            if (temperature < 10)
                result = "Just Cold";
            else if (temperature > 30)
                result = "Just Hot";
            else
                result = "Just Good";

            Console.WriteLine(result);
            #endregion

            #region Q11
            DateTime date;
            string input;

            do
            {
                Console.WriteLine("Enter a valid date (dd/mm/yyyy):");
                input = Console.ReadLine();
            } while (!DateTime.TryParse(input, out date));

            Console.WriteLine($"Today's date: {date.Day} , {date.Month} , {date.Year}");
            Console.WriteLine($"Today's date: {date.Day} / {date.Month} / {date.Year}");
            Console.WriteLine($"Today's date: {date.Day} – {date.Month} – {date.Year}");
            #endregion

            #region Q12
            int n;

            do
            {
                Console.WriteLine("Enter a valid integer:");
            } while (!int.TryParse(Console.ReadLine(), out n));

            if (n % 3 == 0 && n % 4 == 0)
                Console.WriteLine("Yes");

            else
                Console.WriteLine("No");
            #endregion

            #region Q13
            int n;

            do
            {
                console.writeline("enter an integer:");
            } while (!int.tryparse(console.readline(), out n));

            if (n < 0)
                console.writeline("negative");
            else
                console.writeline("positive");
            #endregion

            #region Q14-part1
            int num1, num2, num3;

            do
            {
                Console.WriteLine("Enter the first valid integer:");
            } while (!int.TryParse(Console.ReadLine(), out num1));

            do
            {
                Console.WriteLine("Enter the second valid integer:");
            } while (!int.TryParse(Console.ReadLine(), out num2));

            do
            {
                Console.WriteLine("Enter the third valid integer:");
            } while (!int.TryParse(Console.ReadLine(), out num3));

            Console.WriteLine("Maximum element is: " + Math.Max(num1, Math.Max(num2, num3)));
            Console.WriteLine("Minimum element is: " + Math.Min(num1, Math.Min(num2, num3)));
            #endregion

            #region Q14-part2
            int n;

            do
            {
                Console.WriteLine("Enter a valid integer:");
            } while (!int.TryParse(Console.ReadLine(), out n));

            if (n % 2 == 0)
                Console.WriteLine("EVEN");
            else
                Console.WriteLine("ODD");
            #endregion

            #region Q15
            char c;

            do
            {
                Console.WriteLine("Enter a valid character:");
            } while (!Char.TryParse(Console.ReadLine(), out c) || !Char.IsLetter(c));

            if ("aeiouAEIOU".IndexOf(c) >= 0)
                Console.WriteLine("Vowel");

            else
                Console.WriteLine("Consonant");
            /*

           IndexOf(c):

    The IndexOf method is a built-in function for strings in C#. It searches for the first occurrence of the specified character (c) in the string.
    If the character c is found in the string, IndexOf returns the index (position) of the first occurrence of c in the string. The index is zero-based, so the first character of the string has an index of 0.
    If the character c is not found in the string, IndexOf returns -1.

            */
            #endregion

            #region Q16
            int month;

            Console.Write("Enter month number (1-12): ");
            while (!int.TryParse(Console.ReadLine(), out month) || month < 1 || month > 12)
            {
                Console.Write("Invalid input. Please enter a month number between 1 and 12: ");
            }

            int days;

            switch (month)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    days = 31;
                    break;

                case 4:
                case 6:
                case 9:
                case 11:
                    days = 30;
                    break;

                case 2:
                    days = 28;
                    break;

                default:
                    days = 0;
                    break;
            }

            Console.WriteLine(days);
            #endregion

            #region Q17
            double num1, num2, num3;
            char operation;

            Console.Write("Enter the first number: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            Console.Write("Enter the second number: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            Console.Write("Enter the third number: ");
            while (!double.TryParse(Console.ReadLine(), out num3))
            {
                Console.Write("Invalid input. Please enter a valid number: ");
            }

            Console.Write("Enter the operation (+, -, *, /): ");
            operation = Console.ReadKey().KeyChar;
            Console.WriteLine();

            double result = 0;
            bool validOperation = true;

            switch (operation)
            {
                case '+':
                    result = num1 + num2 + num3;
                    break;

                case '-':
                    result = num1 - num2 - num3;
                    break;

                case '*':
                    result = num1 * num2 * num3;
                    break;

                case '/':
                    do
                    {
                        if (num2 != 0 && num3 != 0)
                        {
                            result = num1 / num2 / num3;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Error: Cannot divide by zero.");
                            Console.Write("Enter the second number (non-zero): ");
                            while (!double.TryParse(Console.ReadLine(), out num2) || num2 == 0)
                            {
                                Console.Write("Invalid input. Please enter a non-zero number: ");
                            }

                            Console.Write("Enter the third number (non-zero): ");
                            while (!double.TryParse(Console.ReadLine(), out num3) || num3 == 0)
                            {
                                Console.Write("Invalid input. Please enter a non-zero number: ");
                            }
                        }
                    } while (num2 == 0 || num3 == 0);
                    break;

                default:
                    Console.WriteLine("Invalid operation.");
                    validOperation = false;
                    break;
            }

            if (validOperation)
            {
                Console.WriteLine($"The result of {num1} {operation} {num2} {operation} {num3} = {result}");
            }
            #endregion

            #region Q18
            int n;
            do
            {
                Console.WriteLine("Input a valid integer: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 1; i <= n; i++)
            {
                Console.Write(i + " ");
            }
            #endregion

            #region Q19
            int n;
            do
            {
                Console.WriteLine("Input a valid integer: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 1; i <= 12; i++)
            {
                Console.Write(n * i);
            }
            #endregion

            #region Q20
            int n;
            do
            {
                Console.WriteLine("Input a valid integer: ");
            } while (!int.TryParse(Console.ReadLine(), out n));

            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.Write(i + " ");
            }
            #endregion

            #region Q21
            int n1, n2;

            do
            {
                Console.WriteLine("Input a base valid integer: ");
            } while (!int.TryParse(Console.ReadLine(), out n1));

            do
            {
                Console.WriteLine("Input a power valid integer: ");
            } while (!int.TryParse(Console.ReadLine(), out n2));

            Console.WriteLine(Math.Pow(n1, n2));
            #endregion

            #region Q22
            int number;

            Console.WriteLine("Enter an integer: ");
            while (!int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Please enter a valid integer: ");
            }

            // Convert the integer to string, reverse it, and convert back to integer
            string reversed = new string(number.ToString().Reverse().ToArray());

            Console.WriteLine("Reversed integer: " + reversed);
            #endregion

            #region Q23
            int start, end;

            Console.WriteLine("Input starting number: ");
            while (!int.TryParse(Console.ReadLine(), out start) || start < 1)
            {
                Console.WriteLine("Please enter a valid integer greater than or equal to 1 for the starting number: ");
            }

            Console.WriteLine("Input ending number: ");
            while (!int.TryParse(Console.ReadLine(), out end) || end < start)
            {
                Console.WriteLine($"Please enter a valid integer greater than or equal to {start} for the ending number: ");
            }

            Console.WriteLine("The prime numbers between " + start + " and " + end + " are:");

            for (int i = start; i <= end; i++)
            {
                if (isPrime(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }

        static bool isPrime(int n)
        {
            if (n <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        #endregion

            #region Q24
        int number;

        Console.WriteLine("Enter a number to convert: ");
        while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
        {
            Console.WriteLine("Please enter a valid non-negative integer: ");
        }

        string binary = ConvertToBinary(number);

        Console.WriteLine($"The Binary of {number} is {binary}");
    }

    static string ConvertToBinary(int n)
    {
        if (n == 0) return "0";

        string binary = "";

        while (n > 0)
        {
            binary = (n % 2) + binary;
            n /= 2;
        }

        return binary;
    }
    #endregion

            #region Q25
    int n;

    Console.WriteLine("Enter array length: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n< 0)
            {
                Console.WriteLine("Please enter a valid non-negative integer: ");
            }

int[] arr = new int[n];

Console.WriteLine($"Enter {n} integers:");
for (int i = 0; i < n; i++)
{
    Console.Write($"Element {i + 1}: ");
    while (!int.TryParse(Console.ReadLine(), out arr[i]))
    {
        Console.WriteLine("Please enter a valid integer: ");
    }
}

int sum = 0;
foreach (int num in arr)
{
    sum += num;
}

Console.WriteLine("Array elements: " + string.Join(", ", arr));
Console.WriteLine("Sum of array elements: " + sum);

#endregion



























































