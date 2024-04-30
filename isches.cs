using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class isches
    {
        public int iscesa;
        public string input;
        public void isc()
        {
            Console.WriteLine($"Выберите систему счисления (1:Numbers, 2:Degress, 3:Logical Operations)");
            num1 g = new num1();
            deg deg = new deg();
            log log = new log();
            input = Console.ReadLine();

            try
            {
                if (int.TryParse(input, out iscesa))
                {
                    switch (iscesa)
                    {
                        case 1:
                            Console.WriteLine("Вы выбрали систему счисления под номером: 1");
                            break;
                        case 2:
                            Console.WriteLine("Вы выбрали систему счисления под номером: 2");
                            break;
                        case 3:
                            Console.WriteLine("Вы выбрали систему счисления под номером: 3");
                            break;
                        default:
                            Console.WriteLine($"Неизвестный система счисления: {iscesa}");
                            Console.WriteLine("Для выхода нажмите любую клавишу...");
                            Console.ReadKey();
                            Environment.Exit(0);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Произошла ошибка: " + ex.Message);
            }
        }
    }
}
