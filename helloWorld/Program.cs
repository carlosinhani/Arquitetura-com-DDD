using System;

namespace HelloWorld
{
    class Program
    /* {
         static void Main(string[] args)

         {
             int variavelTeste;
             variavelTeste =123;

             bool VarivelBoleana = false;

             if (VarivelBoleana == false)
             variavelTeste = 765;

             var TesteInteger = 111;
             var TesteBool = true;
             var TesteString = "Aula";

             Console.WriteLine("O valor da Variável é {0}", variavelTeste);
             Console.WriteLine("O valor da Variável é {0}", TesteInteger);
             Console.WriteLine("O valor da Variável é {0}", TesteBool);
             Console.WriteLine("O valor da Variável é {0}", TesteString);
             Console.ReadLine();

         }
        {
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

         {

            Operadores lógicos.
             //   AND = E   --> &&
             //   OR  = OU  --> ||
             //   NOT = NÂO --> !


             bool teste1 = true;
             bool teste2 = false;

             Console.WriteLine(!teste1);
             Console.WriteLine(!teste2);



         }
     }*/

    {
        static void Main(string[] args)
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
