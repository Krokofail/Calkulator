using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class operats : Oper1
    {
        public class sqr : operats
        {
            public void sq()
            {
                num1 num1 = new num1();
                num1.g();
                double d = num1.numf;
                double result = d * d;
                Console.WriteLine($"Результат: {result}");
            }
        }
        public class sqrt : operats
        {
            public void sf()
            {
                num1 num1 = new num1();
                num1.g();
                if (num1.numf < 0)
                {
                    Console.WriteLine("Корень из отрицательного числа нельзя извлечь");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                double result = Math.Sqrt(num1.numf);
                Console.WriteLine($"Результат: {result}");
            }
        }
        public class sum : operats
        {
            public void c()
            {
                num1 num1 = new num1();
                num1.g();
                num2 num2 = new num2();
                num2.numq();
                double result = num1.numf + num2.numv;
                Console.WriteLine($"Результат: {result}");
            }
        }
        public class min : operats
        {
            public void m()
            {
                num1 num1 = new num1();
                num1.g();
                num2 num2 = new num2();
                num2.numq();
                double result = num1.numf - num2.numv;
                Console.WriteLine($"Результат: {result}");
            }
        }
        public class ym : operats
        {
            public void y()
            {
                num1 num1 = new num1();
                num1.g();
                num2 num2 = new num2();
                num2.numq();
                double result = num1.numf * num2.numv;
                Console.WriteLine($"Результат: {result}");
            }
        }
        public class del : operats
        {
            public void d()
            {
                num1 num1 = new num1();
                num1.g();
                num2 num2 = new num2();
                num2.numq();
                if(num2.numv == 0)
                {
                    Console.WriteLine("Делить на ноль нельзя");
                    Console.WriteLine("Для выхода нажмите любую клавишу...");
                    Console.ReadKey();
                    Environment.Exit(0);
                }
                double result = num1.numf / num2.numv;
                Console.WriteLine($"Результат: {result}");
            }
        }
    }
}
