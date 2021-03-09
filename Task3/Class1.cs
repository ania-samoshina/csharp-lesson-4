using System;

namespace Task3
{
    //3. * Описать класс дробей - рациональных чисел, являющихся отношением двух целых чисел.
    //Предусмотреть методы сложения, вычитания, умножения и деления дробей. Написать программу, 
    //демонстрирующую все разработанные элементы класса.
    //** Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение
    //ArgumentException("Знаменатель не может быть равен 0");
    //Добавить упрощение дробей.

    public class Fraction
    {
        public int Numerator;

        private int _denominator;
        public int Denominator
        {
            get => _denominator;
            set
            {
                if (value == 0)
                {
                    throw new ArgumentException("You cannot divide by 0");
                }
                _denominator = value;
            }
        }

        public Fraction()
        {

        }

        public Fraction(int numerator, int denominator)
        {
            Numerator = numerator;
            Denominator = denominator;
        }

        public void DisplayOutput()
        {
            Console.WriteLine($"{Numerator} / {Denominator}");
        }

        public void DenominatorCheck()
        {

            if (Denominator == 0)
                throw new ArgumentException("You cannot divide by 0");
        }

        public Fraction Add(Fraction fractionToAdd)
        {
            return new Fraction()
            {
                Numerator = Numerator * fractionToAdd.Denominator + fractionToAdd.Numerator * Denominator,
                Denominator = Denominator * fractionToAdd.Denominator
            };
        }

        public Fraction Subtraction(Fraction fractionToSubtraction)
        {
            return new Fraction()
            {
                Numerator = Numerator * fractionToSubtraction.Denominator - fractionToSubtraction.Numerator * Denominator,
                Denominator = Denominator * fractionToSubtraction.Denominator
            };
        }

        public Fraction Multiplication(Fraction fractionToMultiplication)
        {
            return new Fraction()
            {
                Numerator = Numerator * fractionToMultiplication.Numerator,
                Denominator = Denominator * fractionToMultiplication.Denominator
            };

        }

        public Fraction Division(Fraction fractionToDivision)
        {
            return new Fraction()
            {
                Numerator = Numerator * fractionToDivision.Denominator,
                Denominator = Denominator * fractionToDivision.Numerator
            };
        }

        public Fraction Simplify()
        {
            int gcd = GCD(Numerator, Denominator);

            return new Fraction(Numerator / gcd, Denominator / gcd);
        }

        private int GCD(int a, int b)
        {
            int remainder;

            while (b != 0)
            {
                remainder = a % b;
                a = b;
                b = remainder;
            }

            return a;
        }

    }


    public class Task2
    {
        public static void Start()
        {
            try
            {
                Fraction ex = new Fraction();
                ex.Denominator = 0;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Fraction resultAdd = new Fraction(1, 2).Add(new Fraction(10, 25));
            resultAdd.DisplayOutput();
            Fraction fractionSimple = resultAdd.Simplify();
            fractionSimple.DisplayOutput();

            Fraction resultSubtraction = new Fraction(5, 4).Subtraction(new Fraction(6, 7));
            resultSubtraction.DisplayOutput();

            Fraction resultMultiplication = new Fraction(5, 4).Multiplication(new Fraction(6, 7));
            resultMultiplication.DisplayOutput();

            Fraction resultDivision = new Fraction(5, 4).Division(new Fraction(6, 7));
            resultDivision.DisplayOutput();
        }
    }
}
