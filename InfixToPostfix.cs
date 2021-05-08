using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculaor
{
    class InfixToPostfix : SOperator
    {
        #region Calculate

        static public double Calculate(string input)
        {
            try
            {
                return double.Parse(infixToPostfix(input));
            }
            catch (Exception)
            {
                return postfix_evaluation(infixToPostfix(input));
            }
        }

        #endregion

        #region InfixtoPostfix_Evaluation
        public static double postfix_evaluation(string postfix)
        {
            double result, op1, op2;
            Stack<double> stack = new Stack<double>();
            int len = (postfix.Length);
            for (int i = 0; i < len; i++)
            {
                string x = ""; double read_x = 0; char c = ' ';

                if (postfix[i] == ' ')
                    continue;

                #region multidigit_check
                //else if (char.IsDigit(postfix[i]))
                //{
                //int num = 0;

                //while (char.IsDigit(postfix[i]))
                //{
                //    num = num * 10 + (postfix[i] - '0');
                //    i++;
                //}
                //i--;
                //stack.Push(num);
                //}
                #endregion

                //If c is a number or decimal point
                else if (CharUtil.IsDigit(c = postfix[i]))
                {


                    x += c;
                    //The cycle reading includes a decimal point (for example, 8.88+7.777, here will be read in three times, the first cycle reads 8.88,
                    //the second time reads +, the third cycle reads 7.77)
                    while (i < len - 1 && CharUtil.IsDigit(c = postfix[++i]))
                        x += c;

                    //If any number contains ! replacing ! with - and then convert it into number 
                    if (x.Contains("`"))
                    {
                        x = x.Replace("`", "-");
                    }

                    read_x = double.Parse(x);

                    //Read the data into the data stack
                    stack.Push(read_x);
                }

                else
                {
                    op1 = stack.Pop();
                    try
                    {
                        op2 = stack.Pop();
                    }
                    catch (Exception)
                    {
                        op2 = 0;
                    }
                    switch (postfix[i])
                    {
                        case '+':
                            result = (double)(op2 + op1);
                            stack.Push(result);
                            break;
                        case '-':
                            result = (double)(op2 - op1);
                            stack.Push(result);
                            break;
                        case '*':
                            result = (double)(op2 * op1);
                            stack.Push(result);
                            break;
                        case '/':
                            if (op1 == 0)
                            {
                                throw new MathError();
                            }
                            result = (double)(op2 / op1);
                            stack.Push(result);
                            break;
                        case '^':
                            result = (double)(Math.Pow(op2, op1));
                            stack.Push(result);
                            break;
                    }
                }
            }

            result = (double)stack.Pop();
            return result;
            //Console.Write("\nAnswer:: " + result);
        }
        #endregion

        #region InfixtoPostfix_Conversion
        public static string infixToPostfix(string exp)
        {
            //initializing empty String for result 
            string result = "";

            // initializing empty stack 
            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < exp.Length; ++i)
            {
                char c = exp[i];

                // If the scanned character is an operand, add it to output. 
                if (char.IsWhiteSpace(c))
                {
                    continue;
                }

                if (exp[i] == '`')
                {
                    result = result + exp[i];
                }

                else if (char.IsDigit(exp[i]))
                {
                    int operand = 0;

                    while (i < exp.Length && char.IsDigit(exp[i]))
                    {
                        operand = (operand * 10) + (exp[i] - '0');
                        i++;
                    }
                    i--;
                    result = result + operand.ToString() + " ";
                }

                else if (exp[i] == '.')
                {
                    result = result.Trim() + exp[i];
                }


                //else if (exp[i] == '-' && (isDigi(exp[++i])) && (!isDigi(exp[--i * 2])))
                //{
                //    result = result + string.Concat(exp[i], exp[++i]).Trim() + " ";
                //}

                // If the scanned character is an '(', push it to the stack. 
                else if (c == '(')
                {
                    stack.Push(c);
                }

                // If the scanned character is an ')', pop and output from the stack 
                // until an '(' is encountered. 
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        result = result + " " + stack.Pop();
                    }

                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        MessageBox.Show("Invalid Expression"); // invalid expression 
                    }

                    else
                    {
                        stack.Pop();
                    }
                }

                else // an operator is encountered 
                {
                    while (stack.Count > 0 && Prec(c) <= Prec(stack.Peek()))
                    {
                        result = result + " " + stack.Pop();
                    }
                    stack.Push(c);
                }

            }

            // pop all the operators from the stack 
            while (stack.Count > 0)
            {
                result = result + " " + stack.Pop();
            }
            //Console.Write("Postfix Expression::" + result);
            return result;
        }

        bool isDigi(char ch)
        {
            if (ch >= '0' && ch <= '9')
                return true;
            return false;
        }


        #endregion

        #region CheckingDigitOrPoint

        class CharUtil
        {
            public static bool IsDigit(char c)
            {
                return (c >= 48 && c <= 57 || c == '.' || c == '`') ? true : false;
            }
        }
        #endregion
    }
}
