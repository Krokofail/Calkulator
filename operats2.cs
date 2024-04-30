using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class operats2 : Oper2
    {
        public class sin : operats2
        {
            public void si()
            {
                deg deg = new deg();
                deg.n();
                double result = Math.Sin(deg.numd);
                Console.WriteLine($"Результат: {result}");
            }
        }
        public class cos : operats2
        {
            public void cs()
            {
                deg deg = new deg();
                deg.n();
                double result = Math.Cos(deg.numd);
                Console.WriteLine($"Результат: {result}");
            }
        }
        public class tg : operats2
        {
            public void t()
            {
                deg deg = new deg();
                deg.n();
                double result = Math.Tan(deg.numd);
                Console.WriteLine($"Результат: {result}");
            }
        }
        public class ctg : operats2
        {
            public void ct()
            {
                deg deg = new deg();
                deg.n();
                double result = 1 / Math.Tan(deg.numd);
                Console.WriteLine($"Результат: {result}");
            }
        }
    }
}
