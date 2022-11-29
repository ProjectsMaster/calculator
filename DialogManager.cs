using System;

namespace Calculator
{
    class DialogManager
    {
        private CalcManager _calc;

        public DialogManager() {
            _calc = new CalcManager();
        }

        public void AddDialog() {
            Console.WriteLine("\n> Введіть задані числа:");
            Console.Write("  a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("  b = ");
            double b = double.Parse(Console.ReadLine());
            double res = _calc.add(a, b);
            Console.WriteLine($"\n> {a} + {b} =  {res}");
        }

        public void SubDialog() {
            Console.WriteLine("\n> Введіть задані числа:");
            Console.Write("  a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("  b = ");
            double b = double.Parse(Console.ReadLine());
            double res = _calc.sub(a, b);
            Console.WriteLine($"\n> {a} - {b} =  {res}");
        }

        public void MulDialog() {
            Console.WriteLine("\n> Введіть задані числа:");
            Console.Write("  a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("  b = ");
            double b = double.Parse(Console.ReadLine());
            double res = _calc.mul(a, b);
            Console.WriteLine($"\n> {a} * {b} =  {res}");
        }

        public void DivDialog() {
            Console.WriteLine("\n> Введіть задані числа:");
            Console.Write("  a = ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("  b = ");
            double b = double.Parse(Console.ReadLine());
            double res = _calc.div(a, b);
            Console.WriteLine($"\n> {a} / {b} =  {res}");
        }
    }
}