using System;

class Program
{
    static void Main()
    {
        // تعریف آرایه برای ذخیره 100 عدد
        int[] numbers = new int[10];

        // دریافت اعداد از کاربر
        Console.WriteLine("Lotfan 10 adad vared konid:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Adad  {i + 1}:  ra vared konid ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // جدا کردن اعداد زوج و فرد
        int[] evenNumbers = new int[10]; // حداکثر ممکن همه زوج باشند
        int[] oddNumbers = new int[10];   // حداکثر ممکن همه فرد باشند

        int evenCount = 0;
        int oddCount = 0;

        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                evenNumbers[evenCount] = num;
                evenCount++;
            }
            else
            {
                oddNumbers[oddCount] = num;
                oddCount++;
            }
        }

        // نمایش نتایج
        Console.WriteLine("\nEVEN NUMBERS:");
        for (int i = 0; i < evenCount; i++)
        {
            Console.Write(evenNumbers[i] + " ");
        }

        Console.WriteLine("\n\nODD NUMBERS:");
        for (int i = 0; i < oddCount; i++)
        {
            Console.Write(oddNumbers[i] + " ");
        }

        Console.WriteLine("\n\nEVEN NUMBERS: " + evenCount);
        Console.WriteLine("ODD NUMBERS: " + oddCount);
        Console.ReadKey();
    }
}