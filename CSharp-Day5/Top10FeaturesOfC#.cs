#nullable enable
using System;
using System.IO;

namespace CSharp7And8Features
{
    // 1. Default Interface Method (C# 8)
    interface ILogger
    {
        void Log(string message)
        {
            Console.WriteLine($"Default Log: {message}");
        }
    }

    class ConsoleLogger : ILogger { }

    class Program
    {
        static void Main(string[] args)
        {
            // 2. Out Variables (C# 7)
            if (int.TryParse("123", out int number))
            {
                Console.WriteLine($"Parsed number: {number}");
            }

            // 3. Pattern Matching (C# 7)
            object obj = 10;
            if (obj is int x)
            {
                Console.WriteLine($"Pattern matched int: {x}");
            }

            // 4. Tuples (C# 7)
            var person = GetPerson();
            Console.WriteLine($"Name: {person.name}, Age: {person.age}");

            // 5. Local Function (C# 7)
            int Square(int n) => n * n;
            Console.WriteLine($"Square of 5: {Square(5)}");

            // 6. Ref Return (C# 7)
            int[] numbers = { 1, 2, 3 };
            ref int refValue = ref GetElement(numbers, 1);
            refValue = 20;
            Console.WriteLine($"Updated array value: {numbers[1]}");

            // 7. Nullable Reference Types (C# 8)
            string? nullableString = null;
            Console.WriteLine(nullableString?.Length ?? 0);

            // 8. Switch Expression (C# 8)
            int day = 3;
            string dayName = day switch
            {
                1 => "Monday",
                2 => "Tuesday",
                3 => "Wednesday",
                _ => "Other"
            };
            Console.WriteLine($"Day: {dayName}");

            // 9. Using Declaration (C# 8)
            using var reader = new StringReader("Hello World");
            Console.WriteLine(reader.ReadToEnd());

            // 10. Index and Range (C# 8)
            int[] arr = { 10, 20, 30, 40, 50 };
            Console.WriteLine($"Last element: {arr[^1]}");
            var slice = arr[1..4];
            Console.WriteLine("Slice:");
            foreach (var item in slice)
                Console.WriteLine(item);

            // 1. Default Interface Method
            ILogger logger = new ConsoleLogger();
            logger.Log("Hello from interface!");

            Console.ReadLine();
        }

        // Tuple Method
        static (string name, int age) GetPerson()
        {
            return ("Alice", 25);
        }

        // Ref Return Method
        static ref int GetElement(int[] arr, int index)
        {
            return ref arr[index];
        }
    }
}