using System;

namespace lambdaExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericList<int> intlist = new GenericList<int>();
            for(int i= 0; i < 10; i++)
            {
                intlist.Add(i);
            }
            int sum = 0;
            int max = 0;
            int min = 0;
            intlist.ForEach(x => Console.WriteLine(x));
            intlist.ForEach(x => sum += x);
            intlist.ForEach(x => {  if(max < x) max=x; });
            intlist.ForEach(x => { if (min > x) min = x; });
            Console.WriteLine($"Max:{max}");
            Console.WriteLine($"Min:{min}");
            Console.WriteLine($"Sum:{sum}");
        }
    }
}
