using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //While (Enquanto)

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
