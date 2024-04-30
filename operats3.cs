using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class operats3
    {
        public class and : operats3
        {
            public void an()
            {
                log log = new log();
                log.x();
                Console.WriteLine($"Результат: ({log.logs & log.logh})");
            }
        }
        public class ili : operats3
        {
            public void il()
            {
                log log = new log();
                log.x();
                Console.WriteLine($"Результат: ({log.logs | log.logh})");
            }
        }
    }
}
