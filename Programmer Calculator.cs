using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculaor
{
    class Programmer_Calculator
    {
        public static string binary_arithmetic(string s, char op)
        {
            switch (op)
            {
                case '+':
                    {
                        var addAndFive = s.Split('+')[0].Split('+').Sum(c => Convert.ToInt32(c, 2));
                        var addAndTwo = s.Split('+').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 2));
                        return Convert.ToString(addAndFive + addAndTwo, 2);
                    }
                case '-':
                    {
                        var addAndFive = s.Split('-')[0].Split('+').Sum(c => Convert.ToInt32(c, 2));
                        var addAndTwo = s.Split('-').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 2));
                        return Convert.ToString(addAndFive - addAndTwo, 2);
                    }
                case '*':
                    {
                        var addAndFive = s.Split('*')[0].Split('+').Sum(c => Convert.ToInt32(c, 2));
                        var addAndTwo = s.Split('*').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 2));
                        return Convert.ToString(addAndFive * addAndTwo, 2);
                    }
                case '/':
                    {
                        var addAndFive = s.Split('/')[0].Split('+').Sum(c => Convert.ToInt32(c, 2));
                        var addAndTwo = s.Split('/').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 2));
                        return Convert.ToString(addAndFive / addAndTwo, 2);
                    }
                default:
                    return string.Empty;
            }
        }

        public static string octal_arithmetic(string s, char op)
        {
            switch (op)
            {
                case '+':
                    {
                        var addAndFive = s.Split('+')[0].Split('+').Sum(c => Convert.ToInt32(c, 8));
                        var addAndTwo = s.Split('+').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 8));
                        return Convert.ToString(addAndFive + addAndTwo, 8);
                    }
                case '-':
                    {
                        var addAndFive = s.Split('-')[0].Split('+').Sum(c => Convert.ToInt32(c, 8));
                        var addAndTwo = s.Split('-').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 8));
                        return Convert.ToString(addAndFive - addAndTwo, 8);
                    }
                case '*':
                    {
                        var addAndFive = s.Split('*')[0].Split('+').Sum(c => Convert.ToInt32(c, 8));
                        var addAndTwo = s.Split('*').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 8));
                        return Convert.ToString(addAndFive * addAndTwo, 8);
                    }
                case '/':
                    {
                        var addAndFive = s.Split('/')[0].Split('+').Sum(c => Convert.ToInt32(c, 8));
                        var addAndTwo = s.Split('/').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 8));
                        return Convert.ToString(addAndFive / addAndTwo, 8);
                    }
                default:
                    return string.Empty;
            }
        }

        public static string hexa_arithmetic(string s, char op)
        {
            switch (op)
            {
                case '+':
                    {
                        var addAndFive = s.Split('+')[0].Split('+').Sum(c => Convert.ToInt32(c, 16));
                        var addAndTwo = s.Split('+').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 16));
                        return Convert.ToString(addAndFive + addAndTwo, 16);
                    }
                case '-':
                    {
                        var addAndFive = s.Split('-')[0].Split('+').Sum(c => Convert.ToInt32(c, 16));
                        var addAndTwo = s.Split('-').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 16));
                        return Convert.ToString(addAndFive - addAndTwo, 16);
                    }
                case '*':
                    {
                        var addAndFive = s.Split('*')[0].Split('+').Sum(c => Convert.ToInt32(c, 16));
                        var addAndTwo = s.Split('*').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 16));
                        return Convert.ToString(addAndFive * addAndTwo, 16);
                    }
                case '/':
                    {
                        var addAndFive = s.Split('/')[0].Split('+').Sum(c => Convert.ToInt32(c, 16));
                        var addAndTwo = s.Split('/').Skip(1).Sum(c => c == string.Empty ? 0 : Convert.ToInt32(c, 16));
                        return Convert.ToString(addAndFive / addAndTwo, 16);
                    }
                default:
                    return string.Empty;
            }
        }

        public static string bin_dec(string binary)
        {
            return Convert.ToInt64(binary, 2).ToString();
        }

        public static string bin_octal(string binary)
        {
            int integer = Convert.ToInt32(binary, 2);
            return Convert.ToString(integer, 8);
        }

        public static string bin_hexa(string binary)
        {
            int integer = Convert.ToInt32(binary, 2);
            return Convert.ToString(integer, 16).ToUpper();
        }

        public static string dec_bin(Int32 deci)
        {
            return Convert.ToString(deci, 2);
        }

        public static string dec_octal(Int32 deci)
        {
            return Convert.ToString(deci, 8);
        }

        public static string dec_hexa(Int32 deci)
        {
            return Convert.ToString(deci, 16).ToUpper();
        }

        public static string octal_bin(string octal)
        {
            int num;
            int oct = int.Parse(octal);
            while (oct != 0)
            {
                num = oct % 10;
                if (num > 7)
                {
                    throw new OctalError();
                }
                else
                {
                    return Convert.ToString(Convert.ToInt32(octal, 8), 2);
                }
            }
            return string.Empty;
        }

        public static string octal_dec(string octal)
        {
            int num;
            int oct = int.Parse(octal);
            while (oct != 0)
            {
                num = oct % 10;
                if (num > 7)
                {
                    throw new OctalError();
                }
                else
                {
                    return Convert.ToInt32(octal, 8).ToString();
                }
            }
            return string.Empty;
        }

        public static string octal_hexa(string octal)
        {
            int num;
            int oct = int.Parse(octal);
            while (oct != 0)
            {
                num = oct % 10;
                if (num > 7)
                {
                    throw new OctalError();
                }
                else
                {
                    return Convert.ToString(Convert.ToInt64(octal, 8), 16).ToUpper();
                }
            }
            return string.Empty;
        }

        public static string hexa_bin(string hexa)
        {
            return Convert.ToString(Convert.ToInt32(hexa, 16), 2);
        }

        public static string hexa_dec(string hexa)
        {
            return Convert.ToInt32(hexa, 16).ToString();
        }

        public static string hexa_octal(string hexa)
        {
            return Convert.ToString(Convert.ToInt64(hexa, 16), 8);
        }
    }
    class OctalError : MyException
    {
        public OctalError()
        {
            this.MSG = "MATH ERROR";
            MessageBox.Show("NOT AN OCTAL NUMBER");
        }
    }
    class ProgrammerException : Exception
    {
        public string MSG;
        public void MyExceptiona()
        {
            MessageBox.Show("An exception occured");
        }
    }
}
