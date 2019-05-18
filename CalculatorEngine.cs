using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator_18052019
{
    class CalculatorEngine
    {
        public double Calculate(string operand, double first, double second) {
            double result;
            switch (operand.ToLower()) {
                case "add":
                case "+":
                    result = first + second;
                    break;
                case "subtract":
                case "-":
                    result = first - second;
                    break;
                case "multiply":
                case "*":
                    result = first * second;
                    break;
                case "divide":
                case "/":
                    result = first / second;
                    break;
                default:
                    throw new InvalidOperationException("operation not recognized");
             }
            return result;
        }
    }
}
