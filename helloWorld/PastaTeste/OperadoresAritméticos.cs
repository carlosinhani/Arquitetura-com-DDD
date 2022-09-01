using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloWorld.PastaTeste
{
    public class OperadoresAritméticos
    {
       void operadoresAri(string Aritmetica)
        {
            //Operdores Aritméticos
             // + Adição
             // - Substração
             // * Multiplicação
             // / Divisão
             // % Resto da Divisão

             double val1, val2, total;
             val1 = 30;
             val2 = 55;

             total = val1 + val2;

             // total++ incremeto o valor adicinando mais 1  
             // total-- decremeto o valor subtraindo menos 1

             Console.WriteLine("Total é; {0}", total);
             Console.ReadLine();
         }
    }
}