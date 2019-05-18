using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_calculator_18052019
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                InputConverter inputConverter = new InputConverter();
                CalculatorEngine calculatorEngine = new CalculatorEngine();
                double first = inputConverter.ConvertInputToNumber(Console.ReadLine());
                double second = inputConverter.ConvertInputToNumber(Console.ReadLine());
                string operand = Console.ReadLine();

                double result = calculatorEngine.Calculate(operand, first, second);
                Console.WriteLine(result);


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
