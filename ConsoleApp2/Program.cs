using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        int a = 5, b = 3, c = 10, d = -2;
        int minValue = Min(Min(a, b), Min(c, d));
        Console.WriteLine(minValue);
        Console.ReadLine();
    }

    static int Min(int x, int y)
    {
        return (x < y) ? x : y;
    }
}