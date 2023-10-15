using System.Text.RegularExpressions;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        exercice1();
        exercice2();
    } 
    public static void exercice1()
    {
        double z,a=1;
        z = Math.Sin(2 * a)+Math.Sin(5*a)-Math.Sin(3*a)/Math.Cos(a)+1-2*Math.Pow(Math.Sin(1),2)*(2*a);
        Console.WriteLine($"exercise 1 output: {z}");
    }
    public static void exercice2()
    {
        double z, a = 1;
        z = 1/Math.Sqrt(a)+Math.Sqrt(2);
        Console.WriteLine($"exercise 2 output: {z}");
    }
}