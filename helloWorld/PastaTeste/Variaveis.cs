using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace helloWorld.PastaTeste
{
    public class Variaveis
    {
        void variavel(string varias)

        {
            int variavelTeste;
            variavelTeste = 123;

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
    }
}