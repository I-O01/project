using System;

class SimpleCalculator
{
    static void Main()
    {
        Console.WriteLine("=== آلة حاسبة بسيطة ===");
        
        Console.Write("أدخل الرقم الأول: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("أدخل الرقم الثاني: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("اختر العملية (+ , - , * , /): ");
        char op = Console.ReadKey().KeyChar;
        Console.WriteLine();

        double result = 0;

        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                    result = num1 / num2;
                else
                    Console.WriteLine("خطأ: لا يمكن القسمة على صفر!");
                break;
            default:
                Console.WriteLine("عملية غير صحيحة!");
                break;
        }

        Console.WriteLine($"النتيجة: {result}");
    }
}
