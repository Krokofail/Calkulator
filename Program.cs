using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Calculator
{
   public class Program
    {
        static void Main(string[] args)
        {
            isches isches = new isches();
            Oper1 oper = new Oper1();
            Oper2 oper2 = new Oper2();
            Oper3 oper3 = new Oper3();
            povtor povtor = new povtor();
            
            Console.WriteLine("=== Калькулятор ===");
            isches.isc();          
            if (isches.iscesa == 1)
            {
                oper.op();
                int input;
                input = oper.operatio;
                if (input == 5) { operats.sqr sqr = new operats.sqr(); sqr.sq(); }
                if (input == 6) { operats.sqrt sqrt = new operats.sqrt(); sqrt.sf(); }
                if (input == 1) { operats.sum sum = new operats.sum(); sum.c(); }
                if (input == 2) { operats.min min = new operats.min(); min.m(); }
                if (input == 3) { operats.ym ym = new operats.ym(); ym.y(); }
                if (input == 4) { operats.del del = new operats.del(); del.d(); }
            }
            if (isches.iscesa == 2)
            {
                oper2.op();
                if (oper2.operati == 1) { operats2.sin sin = new operats2.sin(); sin.si(); }
                if (oper2.operati == 2) { operats2.cos cos = new operats2.cos(); cos.cs(); }
                if (oper2.operati == 3) { operats2.tg tg = new operats2.tg(); tg.t(); }
                if (oper2.operati == 4) { operats2.ctg ctg = new operats2.ctg(); ctg.ct(); }
            }
            if (isches.iscesa == 3)
            {
                oper3.op();
                if (oper3.operat == 1) { operats3.and and = new operats3.and(); and.an(); }
                if (oper3.operat == 2) { operats3.ili ili = new operats3.ili(); ili.il(); }
            }
            while (true)
            {
                povtor.povto();
            }      
        }   
    }           
}
    


                /*
                 switch (operation)
                     {
                         case "sqr":
                             result = num1 * num1;
                             Console.WriteLine($"Результат: {result}");
                             Console.WriteLine("Для выхода нажмите любую клавишу...");
                             Console.ReadKey();
                             Environment.Exit(0);
                             break;
                         case "sqrt":
                             num1 = Math.Sqrt(num1);
                             result = num1;
                             Console.WriteLine($"Результат: {result}");
                             Console.WriteLine("Для выхода нажмите любую клавишу...");
                             Console.ReadKey();
                             Environment.Exit(0);
                             break;

                     }
                     Console.WriteLine("Введите второе число:");
                 double num2;
                 while (!double.TryParse(Console.ReadLine(), out num2))
                 {
                     Console.WriteLine($"Вы ввели:{num2}");
                     Console.WriteLine("Число не имеет тип double впишите его снова:");
                 }
                 switch (operation)
                     {
                         case "+":
                             result = num1 + num2;
                             break;
                         case "-":
                             result = num1 - num2;
                             break;
                         case "*":
                             result = num1 * num2;
                             break;
                         case "/":
                             if (num2 == 0)
                             {
                                 Console.WriteLine("Деление на ноль невозможно.");
                                 Console.WriteLine("Для выхода нажмите любую клавишу...");
                                 Console.ReadKey();
                                 Environment.Exit(0);
                                 return;
                             }
                             result = num1 / num2;
                             break;
                         default:
                             Console.WriteLine("Неизвестная операция.");
                             return;
                     }

                     Console.WriteLine($"Результат: {result}");
                     Console.WriteLine("Для выхода нажмите любую клавишу...");
                     Console.ReadKey();
                     Environment.Exit(0);
                 }

             if (int.TryParse(Console.ReadLine(), out u) && u == 2 && u != 3 && u!=1)  
             {
                 Console.WriteLine($"Вы выбрали систему счисления под номером: {u}");
                 Console.WriteLine("Введите еденицу измерения градусы:");
                 double num1;
                 while (!double.TryParse(Console.ReadLine(), out num1))
                 {
                     Console.WriteLine($"Вы ввели:{num1}");
                     Console.WriteLine("Число не имеет тип double впишите его снова:");
                 }

                 Console.WriteLine("Введите операцию (sin, cos, tg, ctg):");
                 string operation = Console.ReadLine();

                 if (operation != "cos" && operation != "sin" && operation != "tg" && operation != "ctg")
                 {
                     Console.WriteLine($"Вы ввели:{operation}");
                     Console.WriteLine("Вы ввели неправильную операцию");
                     Console.WriteLine("Для выхода нажмите любую клавишу...");
                     Console.ReadKey();
                     Environment.Exit(0);
                 }
                 double result;
                 switch (operation)
                 {
                     case "sqr":
                         result = num1 * num1;
                         Console.WriteLine($"Результат: {result}");
                         Console.WriteLine("Для выхода нажмите любую клавишу...");
                         Console.ReadKey();
                         Environment.Exit(0);
                         break;
                     case "sqrt":
                         num1 = Math.Sqrt(num1);
                         result = num1;
                         Console.WriteLine($"Результат: {result}");
                         Console.WriteLine("Для выхода нажмите любую клавишу...");
                         Console.ReadKey();
                         Environment.Exit(0);
                         break;
                     case "sin":
                         result = Math.Sin(num1);
                         Console.WriteLine($"Результат: {result}");
                         Console.WriteLine("Для выхода нажмите любую клавишу...");
                         Console.ReadKey();
                         Environment.Exit(0);
                         break;
                     case "cos":
                         result = Math.Cos(num1);
                         Console.WriteLine($"Результат: {result}");
                         Console.WriteLine("Для выхода нажмите любую клавишу...");
                         Console.ReadKey();
                         Environment.Exit(0);
                         break;
                     case "tg":
                         result = Math.Tan(num1);
                         Console.WriteLine($"Результат: {result}");
                         Console.WriteLine("Для выхода нажмите любую клавишу...");
                         Console.ReadKey();
                         Environment.Exit(0);
                         break;
                     case "ctg":
                         result = 1 / Math.Tan(num1);
                         Console.WriteLine($"Результат: {result}");
                         Console.WriteLine("Для выхода нажмите любую клавишу...");
                         Console.ReadKey();
                         Environment.Exit(0);
                         break;

                 }
             }
             if (w == 3&& w != 2 && w != 1)
             {
                 Console.WriteLine($"Вы выбрали систему счисления под номером: {u}");
                 Console.WriteLine("Введите первое число для логической операции:");
                 byte num1;
                 while (!byte.TryParse(Console.ReadLine(), out num1))
                 {
                     Console.WriteLine($"Вы ввели:{num1}");
                     Console.WriteLine("Число не имеет тип byte впишите его снова:");
                 }

                 Console.WriteLine("Введите операцию (&, |):");
                 string operation = Console.ReadLine();

                 if (operation != "&" && operation != "|")
                 {
                     Console.WriteLine($"Вы ввели:{operation}");
                     Console.WriteLine("Вы ввели неправильную операцию");
                     Console.WriteLine("Для выхода нажмите любую клавишу...");
                     Console.ReadKey();
                     Environment.Exit(0);
                 }
                 Console.WriteLine("Введите второе число для логической операции:");
                 byte num2;
                 while (!byte.TryParse(Console.ReadLine(), out num2))
                 {
                     Console.WriteLine($"Вы ввели:{num2}");
                     Console.WriteLine("Число не имеет тип byte впишите его снова:");
                 }
                 if (operation == "&")
                 {
                     Console.WriteLine($"Результат: ({num1 & num2})");
                     Console.WriteLine("Для выхода нажмите любую клавишу...");
                     Console.ReadKey();
                     Environment.Exit(0);
                 }
                 if (operation == "|")
                 {
                     Console.WriteLine($"Результат:({num1 | num2}) ");
                     Console.WriteLine("Для выхода нажмите любую клавишу...");
                     Console.ReadKey();
                     Environment.Exit(0);

                 }
             }
         }
     }
 
}

*/
            
    


