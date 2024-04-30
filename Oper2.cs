using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Oper2
    {
        public int operati;
        public void op()
        {
            char[] arrayw = new char[5];
            arrayw[0] = '1';
            arrayw[1] = '2';
            arrayw[2] = '3';
            arrayw[3] = '4';
            
            Console.WriteLine($"Введите операцию ({arrayw[0]}: sin, {arrayw[1]}: cos, {arrayw[2]}: tg, {arrayw[3]}: ctg):");;
            bool isNumber = int.TryParse(Console.ReadLine(), out operati);
            if (operati < 0 || operati >= arrayw.Length)
            {
                Console.WriteLine($"Вы ввели: {operati}");
                Console.WriteLine("Вы ввели неправильную операцию");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (!isNumber)
            {
                Console.WriteLine($"Вы ввели:{operati}");
                Console.WriteLine("Вы ввели неправильную операцию");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
