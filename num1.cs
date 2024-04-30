using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class num1
    {
        public double numf;
        public void g()
        {
            try
            {
                Console.WriteLine("Введите первое число:");
                while (!double.TryParse(Console.ReadLine(), out numf))
                { Console.WriteLine($"Вы ввели:{numf}"); Console.WriteLine("Число не имеет тип double впишите его снова:"); }
            }
            catch (Exception ex) { Console.WriteLine($"Произошла ошибка: {ex.Message}"); }
        }
    }
}
