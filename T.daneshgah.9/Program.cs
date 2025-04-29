using System;

class Program
{
    static void Main()
    {
        // تعریف آرایه برای ذخیره 5 عدد
        int[] numbers = new int[5];
        bool hasTwo = false;

        // دریافت اعداد از کاربر
        Console.WriteLine("lotfan 5 adad vared konid:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write($"adad {i+1} ra vared konid: ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        // بررسی وجود عدد 2 و موقعیت آن
        Console.WriteLine("\nnatijeh:");
        for (int i = 0; i < 5; i++)
        {
            if (numbers[i] == 2)
            {
                hasTwo = true;
                Console.WriteLine($"adad 2 dar mogheiat {i+1} vojoud darad.");
            }
        }

        if (!hasTwo)
        {
            Console.WriteLine("adad 2 dar bein adad vared shode vojoud nadarad.");
        }
        Console.ReadKey();
    }  
}