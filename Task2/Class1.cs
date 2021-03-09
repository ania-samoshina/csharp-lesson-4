using System;

namespace Task2
{
    //2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке). 
    //Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
    //б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении 
    //ошибки вывести сообщение.Напишите соответствующую функцию;
public class MainClass
    {
        public static void Main()
        {
            int sum = 0;

            while (true)
            {
                try
                {
                    Console.WriteLine("Enter a number");
                    string inputValue = Console.ReadLine();

                    int number;
                    if (int.TryParse(inputValue, out number))
                    {
                        if (number == 0)
                        {
                            break;
                        }

                        sum += number;
                    }
                    else
                    {
                        throw new ArgumentException("Вы ввели не число, а какую то фигню");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine($"Total sum is {sum}");
        }
    }
}

