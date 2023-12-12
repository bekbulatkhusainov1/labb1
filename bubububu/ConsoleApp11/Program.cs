namespace ConsoleApp11
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите натуральное число для проверки на палиндром:");
            string input = Console.ReadLine();
            int number;

            if (int.TryParse(input, out number))
            {
                if (IsPalindrome(number))
                {
                    Console.WriteLine($"{number} - является палиндромом.");
                }
                else
                {
                    Console.WriteLine($"{number} - не является палиндромом.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка: введено некорректное значение.");
            }
        }

        static bool IsPalindrome(int number)
        {
            string numberString = number.ToString();
            int length = numberString.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (numberString[i] != numberString[length - i - 1])
                {
                    return false;
                }
            }

            return true;
        }



    }
}