using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
namespace oap { }

public class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Введите три числа ");

        //возведение в степень: Math.pow(double, double)
        var a = Convert.ToDouble(Console.ReadLine());
        var b = Convert.ToDouble(Console.ReadLine());
        var c = Convert.ToDouble(Console.ReadLine());

        if(a>=0) a = Math.Pow(a, 2);
        else a = Math.Pow(b, 4);

        b = b >= 0 ? Math.Pow(b, 2) : Math.Pow(b, 4);

        c = c >= 0 ? Math.Pow(c, 2) : Math.Pow(c, 4);
        Console.WriteLine($"a={a} b={b} c={c}");

        Console.ReadLine();
        

Console.WriteLine("Ввод Х1:");
var X1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввод Y1:");
var Y1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввод X2:");
var X2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Ввод Y2:");
var Y2 = Convert.ToDouble(Console.ReadLine());
var Dlina1 = Math.Sqrt(Math.Pow(X1, 2) + Math.Pow(Y1, 2));
var Dlina2 = Math.Sqrt(Math.Pow(X2, 2) + Math.Pow(Y2, 2));
if (Dlina1 < Dlina2)
{
    Console.WriteLine("первая точка ближе");
}
else
        {
    Console.WriteLine("вторая точка ближе");
   Console.ReadLine();
        }
    }
}







