using System;

    class Program
    {
          static double Calculatefuntion(double x)
        {
            if (x * x <= 4)
                return 2;
                
            else
                return 1 + Calculatefuntion(x - (4 * (Math.Abs(x) / x) ) );

        }
        static void Main(string[] args)
        {   double x,output;
            Console.Write("Input number x = ");
            x = double.Parse(Console.ReadLine());

            output = Calculatefuntion(x);
            Console.WriteLine("f({0}) = {1}",x,output);
        }
    }