using CalculatorLib.Swabhav;
using System;
using System.Collections.Generic;
using System.Text;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            Console.WriteLine(calculator.CubeEvenNumber(5));
        }
    }
}
