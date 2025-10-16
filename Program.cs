using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public delegate int NumChange(int n);

class Test
{
    static int num = 10;
    public static int Addnum(int p)
    {
        return (num += p);
    }
    public static int Mult(int p)
    {
        return (num *= p);
    }
    public static int getNum()
    {
        return num;
    }
    /*static void Main(string[] args)
    {
        NumChange nc;
        NumChange nc1 = new NumChange(Addnum);
        NumChange nc2 = new NumChange(Mult);
        nc = nc1;
        nc += nc2;
        nc1(25);
        Console.WriteLine("Value of Num: {0}", getNum());
        nc2(5);
        Console.WriteLine("Value of Num: {0}", getNum());
        nc(5);
        Console.WriteLine("Value of Num: {0}", getNum());
        Console.ReadKey();
    }*/
}
