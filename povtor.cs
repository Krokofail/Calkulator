using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class povtor
    {
        public void povto()
        {
            isches isches = new isches(); Oper1 oper = new Oper1(); Oper2 oper2 = new Oper2(); Oper3 oper3 = new Oper3();    
            char Y = 'Y';
            char N = 'N';
            Console.WriteLine($"Хотите ли вы ещё раз использовать калькулятор : {Y}, {N}");
            char userInput = char.Parse(Console.ReadLine());
            if (userInput == Y)
            {
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
            }
            else if (userInput == N)
            {
                Console.WriteLine("Для выхода из калькулятора нажмите любую клавишу...");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }
    }
}

