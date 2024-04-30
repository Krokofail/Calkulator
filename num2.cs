using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class num2
    {
        public double numv;
        public void numq()
        {
            try
            {
                Console.WriteLine("Введите второе число:");
                while (!double.TryParse(Console.ReadLine(), out numv))
                {
                    Console.WriteLine($"Вы ввели:{numv}");
                    Console.WriteLine("Число не имеет тип double впишите его снова:");
                }
            }
            catch (Exception ex) { Console.WriteLine("Произошла ошибка: " + ex.Message); }
        }
    }
}
