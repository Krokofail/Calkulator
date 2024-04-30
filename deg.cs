using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class deg
    {
        public double numd;
        public void n()
        {
            try
            {
                Console.WriteLine("Введите единицу измерения градусы:");
                while (!double.TryParse(Console.ReadLine(), out numd))
                {
                    Console.WriteLine($"Вы ввели:{numd}");
                    Console.WriteLine("Число не имеет тип double впишите его снова:");
                }
            }
            catch (Exception ex) { Console.WriteLine($"Произошла ошибка: {ex.Message}"); }
        }

    }
}
