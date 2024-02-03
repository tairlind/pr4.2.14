using System;

namespace Summa
{
    class Program
    {
        static void Main(string[] args)
        {
            string number1, number2;
            Console.WriteLine("введите первое число:");
            number1 = Console.ReadLine();
            Console.WriteLine("введите второе число:");
            number2 = Console.ReadLine();

            string result = bignumbers(number1, number2);
            Console.WriteLine("результат сложения: " + result);
        }

        static string bignumbers(string num1, string num2)
        {
            int maxLength = Math.Max(num1.Length, num2.Length);
            num1 = num1.PadLeft(maxLength, '0');
            num2 = num2.PadLeft(maxLength, '0');

            int carry = 0;
            string result = "";

            for (int i = maxLength - 1; i >= 0; i--)
            {
                int sum = (num1[i] - '0') + (num2[i] - '0') + carry;
                carry = sum / 10;
                result = (sum % 10).ToString() + result;
            }

            if (carry > 0)
            {
                result = carry.ToString() + result;
            }

            return result;
        }
    }
}
