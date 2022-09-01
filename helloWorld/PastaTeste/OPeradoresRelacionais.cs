using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloWorld.PastaTeste
{
    public class OPeradoresRelacionais
    {
         void relaconais(string operRelacionais)
        {
            // Operadores Relacionais

            // == igual a
            // =! Diferente de
            // > Maior que 
            // < Menor que 
            // >= Maior igual a
            // <= Menor igual a

            var val1 = 10;
            var val2 = 40;

            Console.WriteLine("Igual: {0}", val1 == val2);
            Console.WriteLine("Diferente de : {0}", val1 != val2);
            Console.WriteLine("Maior que : {0}", val1 > val2);
            Console.WriteLine("Menor que: {0}", val1 < val2);
            Console.WriteLine("Maior igual a : {0}", val1 >= val2);
            Console.WriteLine("Menor igual a: {0}", val1 <= val2);
        }
    }
}
