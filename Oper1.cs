using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Oper1 : isches
    {
        public int operatio; 
 
public void op()
        {
            int[] numArray = new int[7];
            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;
            numArray[5] = 6;
            Console.WriteLine($"Введите операцию ({numArray[0]}: +, {numArray[1]}: -, {numArray[2]}: *, {numArray[3]}: /, {numArray[4]}: sqr, {numArray[5]}: sqrt):");
            bool isNumber = int.TryParse(Console.ReadLine(), out operatio);
            if (operatio < 0 || operatio >= numArray.Length) 
            {
                Console.WriteLine($"Вы ввели: {operatio}");
                Console.WriteLine("Вы ввели неправильную операцию");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else if (!isNumber){
                Console.WriteLine($"Вы ввели: {operatio}");
                Console.WriteLine("Вы ввели неправильную операцию");
                Console.WriteLine("Для выхода нажмите любую клавишу...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}
