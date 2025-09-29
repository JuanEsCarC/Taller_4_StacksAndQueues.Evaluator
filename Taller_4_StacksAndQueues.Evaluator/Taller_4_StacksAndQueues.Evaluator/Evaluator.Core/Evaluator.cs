
namespace Evaluator.Core;

public class ExpressionEvaluator ()
{

    public static double Evaluate(string infix)
    {
        var postfixKeys = InfixToPostfix(infix);
        return Calculate(postfixKeys);         
    }

    private static List<string> InfixToPostfix(string infix)
    {
        var stack = new Stack<char>();
        var keys = new List<string>();
        
        for (int i = 0; i < infix.Length; i++)
        {
            char item = infix[i];

            if (char.IsDigit(item) || item == '.')
            {
                string number = string.Empty;
                while (i < infix.Length && (char.IsDigit(infix[i]) || infix[i] == '.'))
                {
                    number += infix[i];
                    i++;
                }
                i--;
                keys.Add(number);
            }
            else 
            {
                if (IsOperator(item))
                {
                    if (item == ')')
                    {
                        while (stack.Count > 0 && stack.Peek() != '(')
                        {
                            keys.Add(stack.Pop().ToString());
                        }

                        if (stack.Count > 0 && stack.Peek() == '(')
                        {
                            stack.Pop();
                        }
                    }
                    else 
                    {
                        while (stack.Count > 0 && PriorityStack(stack.Peek()) >= PriorityInFix(item))
                        {
                            keys.Add(stack.Pop().ToString());
                        }                   
                        stack.Push(item);
                    }
                }   
            }
        }

        while (stack.Count > 0)
        {
            keys.Add(stack.Pop().ToString());
        }

        return keys;
    }

    private static bool IsOperator(char item) => item is '+' or '-' or '*' or '/' or '%' or '^' or '(' or ')';


    private static int PriorityInFix (char op) => op switch
    {
        '^' => 4,
        '*' or '/' or '%' => 2,
        '+' or '-' => 1,
        '(' => 5, 
        _ => throw new Exception ("Invalid expression"),
    };

    private static int PriorityStack(char op) => op switch
    {
        '^' => 3,
        '*' or '/' or '%' => 2,
        '+' or '-' => 1,
        '(' => 0,
        _ => throw new Exception("Invalid expression"),
    };


    private static double Calculate(List<string> postfixKeys)
    {
        var stack = new Stack<double>();

        foreach (var key in postfixKeys)
        {
            char item = key[0];
            
            if (IsOperator(item))
            {
                var op2 = stack.Pop();
                var op1 = stack.Pop();
                stack.Push(Calculate(op1, item, op2));
            }
            else
            {
                stack.Push(Convert.ToDouble(key.ToString()));
            }
        }

        return stack.Peek();
    }

    private static double Calculate(double op1, char item, double op2) => item switch
    {
        '*' => op1 * op2,
        '/' => op1 / op2,
        '^' => Math.Pow(op1, op2),
        '+' => op1 + op2,
        '-' => op1 - op2,
        _ => throw new Exception("Invalid expression."),
    };
}
