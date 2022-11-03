//By Joanthan CHANG

using System;

namespace std
{
    public class Evaluator
    {
        static public void Main(String[] args)
        {
            int result;
            string expression;
            bool noError;

            while (true)
            {
                var exit = "";

                Console.Write("Input an expression: ");
                expression = Console.ReadLine();

                noError = evaluate(expression, out result);

                if (noError)
                {Console.WriteLine("Result: " + result);}

                else
                {Console.WriteLine("Result : N/A");}

                Console.WriteLine("(Press y/Y to exit or Press ENTER to input again.)");
                exit = (Console.ReadLine().ToLower());
                
                if (exit == "y" )
                {break;}
            }
            Console.WriteLine("~ Bye ~");
        }
        
        static public bool evaluate(string expression, out int result)
        {
            
            int left = 0;
            int right = 0;
            bool reading_next = false; 
            bool Error = false;
            int length;

            expression = expression.Replace(" ", String.Empty);////Remove all the spaces//
            length = expression.Length;
            
            ////Extract each position from the String//
            for (int i = 0; i < length && Error == false; i++)
            {
                char ch = expression[i];

                ///Identify charater type from each position of the Sting//

                // -- If it is number -- //
                if (reading_next == false && System.Char.IsDigit(ch))
                {
                    left = 10*left + (ch - '0');
                }

                // -- If it is NOT number (Operator) -- //
                else 
                {
                    int j;
                    switch(ch)
                    {
                        case '+':
                            right = 0;
                            j = i+1;

                            if (System.Char.IsDigit(expression[j]))
                            {
                                while(j < length && System.Char.IsDigit(expression[j]))
                                {
                                    right = 10*right + (expression[j] - '0');
                                    j++;
                                }
                            }
                            else if (expression[j] == '(')
                            {
                                int par = 1;

                                while(par > 0 && j < length-1)
                                {
                                    j++;
                                    if(expression[j] == ')'){par--;}
                                    else if(expression[j] == '('){par++;}
                                    if(par == 0){break;}
                                }
								j++;
                                
                                if (par == 0)
                                {
                                    evaluate(expression.Substring(i+1,j-i-1), out right);
                                }
                                else
                                {
                                    Error = true;
                                }
                            }

                            left += right;
                            i = j - 1;
                            break;

                        case '-':
                            right = 0;
                            j = i+1;

                            if (System.Char.IsDigit(expression[j]))
                            {
                                while(j < length && System.Char.IsDigit(expression[j]))
                                {
                                    right = 10*right + (expression[j] - '0');
                                    j++;
                                }
                            }
                            else if (expression[j] == '(')
                            {
                                int par = 1;
                                
                                while(par > 0 && j < length)
                                {
                                    j++;
                                    if(expression[j] == ')'){par--;}
                                    else if(expression[j] == '('){par++;}
                                    if(par == 0){break;}
                                }
								j++;

                                if (par == 0)
                                {
                                    evaluate(expression.Substring(i+1,j-i-1), out right);
                                }
                                else
                                {
                                    Error = true;
                                }
                            }

                            left -= right;
                            i = j - 1;
                            break;

                        case '*':
                            right = 0;
                            j = i+1;

                            if (System.Char.IsDigit(expression[j]))
                            {
                                while(j < length && System.Char.IsDigit(expression[j]))
                                {
                                    right = 10*right + (expression[j] - '0');
                                    j++;
                                }
                            }
                            else if (expression[j] == '(')
                            {
                                int par = 1;

                                while(par > 0 && j < length)
                                {
                                    j++;
                                    if(expression[j] == ')'){par--;}
                                    else if(expression[j] == '('){par++;}
                                    if(par == 0){break;}
                                }
								j++;

                                if (par == 0)
                                {
                                    evaluate(expression.Substring(i+1,j-i-1), out right);
                                }
                                else
                                {
                                    Error = true;
                                }
                            }

                            left *= right;
                            i = j - 1;
                            break;

                        case '/':
                            right = 0;
                            j = i+1;

                            if (System.Char.IsDigit(expression[j]))
                            {
                                while(j < length && System.Char.IsDigit(expression[j]))
                                {
                                    right = 10*right + (expression[j] - '0');
                                    j++;
                                }
                            }
                            else if (expression[j] == '(')
                            {
                                int par = 1;

                                while(par > 0 && j < length)
                                {
                                    j++;
                                    if(expression[j] == ')'){par--;}
                                    else if(expression[j] == '('){par++;}
                                    if(par == 0){break;}
                                }
								j++;

                                if (par == 0)
                                {
                                    evaluate(expression.Substring(i+1,j-i-1), out right);
                                }
                                else
                                {
                                    Error = true;
                                }
                            }

                            left /= right;
                            i = j - 1;
                            break;

                        case '(':
                            int par2 = 1;
                            
                            j = i;
                            while(par2 > 0 && j < length-1)
                            {
                                j++;
                                if(expression[j] == ')'){par2--;}
                                else if(expression[j] == '('){par2++;}
                                if(par2 == 0){break;}
                            }

                            if (par2 == 0)
                            {
                                evaluate(expression.Substring(i+1,j-i-1), out left);
                            }
                            else
                            {
                                Error = true;
                            }

                            i = j;
                            break;

                        default:
                            Error = true;
                            break;
                    }
                }
            }

            ///Carry out result//
            if (Error)
            {
                result = 0; //The expression has error , so no result//
            }
            else
            {
                result = left; //Store final answer to result//
            }

            return !Error; //Ending the Method 
        }
    }
}