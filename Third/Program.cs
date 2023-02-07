using System.ComponentModel;
using System;
class Program{
    static double Calculatefunction(double X){
        double keep = 1-(X*X);

        if(X > -1 && X <= 0)
            return  Math.Sqrt(keep);
        
        else if(X>0 && X <=1)
            return  -Math.Sqrt(keep);
        
        else if(X <= -1)
            return Calculatefunction(X+2);
    
        else
            return Calculatefunction(X-2);
        
    }
    static void Main(string[] args){
        Console.Write("Input number x = ");
        double x = double.Parse(Console.ReadLine());
        double output = Calculatefunction(x);

        Console.WriteLine("f({0}) = {1}",x,output);

    }
}