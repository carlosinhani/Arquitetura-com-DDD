using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloWorld.PastaTeste
{
    public class WhileeBreak
    {
      void whileBreak(string enquanto)  
      {
          int x = 0;
            while (x < 10)
            {
                x++;

                if (x % 2 == 0)
                    continue;

                if (x == 7)
                    break;

                Console.WriteLine(x);
            }
            Console.WriteLine("Saiu do While");
      }
    }
}