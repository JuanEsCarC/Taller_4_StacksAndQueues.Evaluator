
using Evaluator.Core;


Console.WriteLine("Hello, Evaluator");

var infix = "1+2";
var result = ExpressionEvaluator.Evaluate(infix);
Console.WriteLine($"{infix} = {result}");