using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //switch...case (caso)

            //   int x = 1;

            //   switch (x)
            //   {
            //     case 1:
            //     Console.WriteLine("Igual a 1");
            //     break;
            //     case 2:
            //     Console.WriteLine("Igual a 2");
            //     break;
            //     case 3:
            //     Console.WriteLine("Igual a 3");
            //     break;

            //     default:
            //     Console.WriteLine("Default");
            //     break;
            //   }

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Sunday:
                case DayOfWeek.Saturday:
                    Console.WriteLine("Final de Semana");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Primeiro Dia da Semana de trabalho");
                    break;
                case DayOfWeek.Friday:
                    Console.WriteLine("Ultimo Dia da Semana de trabalho");
                    break;
                default:
                    Console.WriteLine("Meio da Semana");
                    break;
            }
        }
    }
}
