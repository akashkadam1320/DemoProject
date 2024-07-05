// See https://aka.ms/new-console-template for more information  
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DemoProject { 
    class Test1
{
    public int add(int a, int b)
    {
        return a + b;
    }
    public double sub(int c, int d)
    {
        return c - d;
    }
    public double multi(int e, int f)
    {
        return e * f;
    }
    public double div(int g, int h)
    {
        return g / h;
    }
}
class TestClass
{
     static void Main(string[] args)
    {   // object creation 

        Test1 th = new Test1();

        int sum = th.add(10, 2);
        double sub = th.sub(10, 2);
        double multi = th.multi(10, 2);
        double div = th.div(10, 2);
        Console.WriteLine("sum of Integer:" + sum);
        Console.WriteLine("substraction:" + sub);
        Console.WriteLine("multiplication:" + multi);
        Console.WriteLine("division:" + div);
    }
} 
}