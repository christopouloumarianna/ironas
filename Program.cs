using System;

namespace Ironas
{


    static void Main(string[] args)
    {

        Console.WriteLine("give a=");
        double a = double.Parse(Console.ReadLine());

        Console.WriteLine("give b=");
        double b = double.Parse(Console.ReadLine());

        Console.WriteLine("give c=");
        double c = double.Parse(Console.ReadLine());

        double r = (a + b + c) / 2;

        double E = Math.Sqrt(r * (r - a) * (r - b) * (r - c));



        Console.WriteLine("E= {0}", E);

        Console.ReadLine();
    }




}


