using System;

namespace Program2
{
    public class Complex
    {
        private double m_real = 0.0;
        private double m_imag = 0.0;


        public Complex(double re, double im)
        {
            m_real = re;
            m_imag = im;
        }
        public double Real
        {
            get { return m_real; }
            set { m_real = value; }
        }

        public double Imag
        {
            get { return m_imag; }
            set { m_imag = value; }
        }
        public Complex GetConjugate()
        {
            return new Complex(m_real, -m_imag);
        }

        public override string ToString()
        {
            string res = "";

            if (m_real != 0.0)
            {
                res = m_real.ToString();
            }

            if (m_imag != 0.0)
            {
                if (m_imag > 0)
                {
                    res += "+";
                }

                res += m_imag.ToString() + "i";
            }

            return res;
        }



        public static Complex operator +(Complex c1, Complex c2)
        {
            return new Complex(c1.Real + c2.Real, c1.Imag + c2.Imag);
        }




        public static Complex operator -(Complex c1, Complex c2)
        {
            return new Complex(c1.Real - c2.Real, c1.Imag - c2.Imag);
        }


        public static Complex operator *(Complex c1, Complex c2)
        {
            return new Complex(c1.Real * c2.Real - c1.Imag * c2.Imag,
                c1.Real * c2.Imag + c1.Imag * c2.Real);
        }


        public static Complex operator /(Complex c1, Complex c2)
        {
            double Denominator = c2.Real * c2.Real + c2.Imag * c2.Imag;
            return new Complex((c1.Real * c2.Real + c1.Imag * c2.Imag) / Denominator,
                (c2.Real * c1.Imag - c2.Imag * c1.Real) / Denominator);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Complex re1 = new Complex(25.5, 24.6);
            Complex re2 = new Complex(4.8, 5.9);
            String key;
            do
            {
                Console.WriteLine("1) Показать числа");
                Console.WriteLine("2) Сложение");
                Console.WriteLine("3) Вычитание");
                Console.WriteLine("4) Умножение");
                Console.WriteLine("5) Деление");
                Console.WriteLine("6) Выход");
                key = Console.ReadLine();
                Convert.ToInt32(key);
                switch (key)
                {
                    case "1":
                        Console.WriteLine(re1);
                        Console.WriteLine(re2);
                        break;
                    case "2": Console.WriteLine(re1 + re2); break;
                    case "3": Console.WriteLine(re1 - re2); break;
                    case "4": Console.WriteLine(re1 * re2); break;
                    case "5": Console.WriteLine(re1 / re2); break;
                }
            } while (key != "6");
            Console.Write("Завершение работы программы 2");
            Console.ReadKey(true);
        }
    }
}