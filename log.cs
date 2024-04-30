using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class log
    {
        public byte logs;
        public byte logh;
        public void x()
        {
            Console.WriteLine("Введите первое число для логической операции:");
            while (!byte.TryParse(Console.ReadLine(), out logs))
            {
                Console.WriteLine($"Вы ввели:{logs}");
                Console.WriteLine("Число не имеет тип byte впишите его снова:");
            }
            Console.WriteLine("Введите второе число для логической операции:");
            while (!byte.TryParse(Console.ReadLine(), out logh))
            {
                Console.WriteLine($"Вы ввели:{logh}");
                Console.WriteLine("Число не имеет тип byte впишите его снова:");
            }
        }
    }
}
