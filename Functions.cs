using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculaor
{
    class Functions
    {
        public static double fact(double n)
        {
            if (n == 1 || n == 0)
                return 1;
            if (n < 0)
            {
                throw new MathError();
            }
            return n * fact(n - 1);
        }
        public double nPr(double n, double r)
        {
            return fact(n) / fact(n - r);
        }
        public double nCr(double n, double r)
        {
            return fact(n) / (fact(r) * fact(n - r));
        }
        public int GCD(int a, int b)
        {
            if (b == 0)
            {
                return a;
            }
            else
            {
                return GCD(b, a % b);
            }
        }
        public int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b);
        }

        public double LognN(int Base, double n)
        {
            if (n <= 0)
            {
                MessageBox.Show("THE VALUES SHOULD NOT BE LESS THAN OR EQUALS TO 0");
                throw new MathError();
            }
            else
                return (Math.Log10(n) / Math.Log10(Base));
        }

        public double root_of_power(double n, int pow)
        {
            double result;
            if ((pow % 2 == 0) && n < 0)
            {
                MessageBox.Show("THE ROOT OF POWER 0 IS INDERTMINATE\n");
                throw new MathError();
            }
            result = Math.Pow(n, (double)1 / pow);
            return result;
        }

        public static double Logarthimic_Function(string func, double n)
        {
            switch (func)
            {
                case "ln(":
                    if (n <= 0)
                    {
                        MessageBox.Show("THE VALUES SHOULD NOT BE LESS THAN OR EQUALS TO 0");
                        throw new MathError();
                    }
                    else
                    {
                        return Math.Log(n);
                    }

                case "log(":
                    if (n <= 0)
                    {
                        MessageBox.Show("THE VALUES SHOULD NOT BE LESS THAN OR EQUALS TO 0");
                        throw new MathError();
                    }
                    else
                    {
                        return Math.Log10(n);
                    }

                case "e^(":
                    return Math.Exp(n);

                case "sqrt(":
                    if (n < 0)
                    {
                        MessageBox.Show("THE VALUES SHOULD NOT BE LESS THAN 0");
                        throw new MathError();
                    }
                    else
                    {
                        return Math.Sqrt(n);
                    }

                case "cbrt(":
                    double result;
                    result = Math.Pow(n, 1.0 / 3.0);
                    return result;

                case "!":
                    return Functions.fact(n);

                default: return 0;
            }
        }

        public static double TRIGNOMETRY(string func, double n)
        {
            switch (func)
            {
                case "sin(":
                    return Math.Sin(n);

                case "cos(":
                    return Math.Cos(n);

                case "tan(":
                    return Math.Tan(n);

                case "cot(":
                    return (1 / Math.Tan(n));

                case "cosec(":
                    return (1 / Math.Sin(n));

                case "sec(":
                    return (1 / Math.Cos(n));

                case "asin(":
                    if (n < -1 || n > 1)
                    {
                        MessageBox.Show("THE VALUES SHOULD NOT BE LESS THAN -1 OR  GREATER THAN 1");
                        throw new MathError();
                    }
                    else
                    {
                        return Math.Asin(n);
                    }

                case "acos(":
                    if (n < -1 || n > 1)
                    {
                        MessageBox.Show("THE VALUES SHOULD NOT BE LESS THAN -1 OR  GREATER THAN 1");
                        throw new MathError();
                    }
                    else
                    {
                        return Math.Acos(n);
                    }

                case "atan(":
                    return Math.Atan(n);

                case "acot(":
                    return (1 / Math.Atan(n));

                case "acosec(":
                    return (1 / Math.Asin(n));

                case "asec(":
                    return (1 / Math.Acos(n));

                case "sinh(":
                    return (Math.Sinh(n));

                case "cosh(":
                    return (Math.Cosh(n));

                case "tanh(":
                    return (Math.Tanh(n));

                case "cosech(":
                    return (1 / Math.Sinh(n));

                case "sech(":
                    return (1 / Math.Cosh(n));

                case "coth(":
                    return (1 / Math.Tanh(n));

                case "asinh(":
                    return (Math.Log(n + Math.Sqrt(n * n + 1)));

                case "acosh(":
                    return (Math.Log(n + Math.Sqrt(n * n - 1)));

                case "atanh(":
                    return (Math.Log((1 + n) / (1 - n)) / 2);

                case "acosech(":
                    return (Math.Log((Math.Sign(n) * Math.Sqrt(n * n + 1) + 1) / n));

                case "asech(":
                    return (Math.Log((Math.Sqrt(-n * n + 1) + 1) / n));

                case "acoth(":
                    return (Math.Log((n + 1) / (n - 1)) / 2);

                default: return 0;
            }
        }
    }
    class MathError : MyException
    {
        public MathError()
        {
            this.MSG = "MATH ERROR";
            MessageBox.Show("MATH ERROR OCCURED");
        }
    }
    class MyException : Exception
    {
        public string MSG;
        public void MyExceptiona()
        {
            MessageBox.Show("An exception occured");
        }
    }
    class DivideByZero : MyException
    {
        public DivideByZero()
        {
            this.MSG = "MATH ERROR";
            MessageBox.Show("DIVIDE BY ZERO EXCEPTION OCCURED\nPLEASE ENTER THE VALUE AGAIN");
        }
    }
}

