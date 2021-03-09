using System;

namespace Task1
{
    //1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
    //б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса;
 
 
        public  class Complex
        {

            #region Public Methods


            // Вычитание комплексных чисел
            // <param name="complex">Комплексное число</param>
            // <returns>Результат вычитания комплексных чисел</returns>
            public Complex Minus(Complex complex)
            {
                Complex c = new Complex();
                c.Re = _re - complex.Re;
                c._im = _im - complex._im;
                return c;
            }


            // Перегрузка оператора -, вычитание комплексных чисел
            // </summary>
            // <param name="complex1">Комплексное число</param>
            // <param name="complex2">Комплексное число</param>
            // <returns>Результат вычитания комплексных чисел</returns>
            public static Complex operator -(Complex complex1, Complex complex2)
            {
                return new Complex { Re = complex1.Re - complex2.Re, Im = complex1.Im - complex2.Im };
            }

            public static Complex operator *(Complex complex1, Complex complex2)
        {
            return new Complex
            {
                Re = complex1.Re * complex2.Re - complex1.Im * complex2.Im,
                Im = complex1.Re * complex2.Im + complex1.Im * complex2.Re
            };
        }

            public override string ToString()
            {
                return $"{_re} {_im}i";
            }

            #endregion

            #region Constructors

            public Complex() { }

            public Complex(double re, double im)
            {
                _re = re;
                this._im = im;
            }

            #endregion

            #region Fields

            private double _re;
            private double _im;

            #endregion

            #region Properties

            public double Re
            {
                get { return _re; }
                set { _re = value; }
            }

            public double Im
            {
                get { return _im; }
                set { _im = value; }
            }

            #endregion
        }

    public class Program
    {
        public static void Main1()
        {
            Complex complex1 = new Complex(5, -6);
            Complex complex2 = new Complex(-3, 2);

            Console.WriteLine($"Working with complex numbers {complex1} and {complex2}");
            Console.WriteLine($"Result of subtracting complex numbers {complex1 - complex2}");
            Console.WriteLine($"The result of multiplying complex numbers {complex1 * complex2}");

            Console.ReadLine();
        }
    }
    
}
