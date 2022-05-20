using System;

namespace add
{
    class sum
    {
        static void Main(string[] args)
        {
            int from, to;

            Console.Write("ilk ededi daxil edin:  ");
            from = int.Parse(Console.ReadLine());
            Console.Write("ikinci ededi daxil edin:  ");
            to = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = from; i < to; i++)
            {
                sum += i;

            }
            Console.WriteLine("Iki eded arasindaki ededlerin cemi " + sum);
        }

    }
}
