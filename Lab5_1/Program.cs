// Lab5_1.cs
// <Возняк Едвард>
// Лабораторна робота № 5.1
// Функції, що містять арифметичний вираз
// Варіант 5
public class Lab5_1
{   
    static void Main(string[] args)
    {
        double s, t;

        Console.WriteLine("Enter s value:");
        s = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter t value:");
        t = double.Parse(Console.ReadLine());

        double c = (Math.Pow(h(s,t),4)+h(1.0,Math.Pow(s,2)+Math.Pow(t,2)))/(1.0+Math.Pow(h(s*t,1),2));

        Console.WriteLine($"c = {c:F8}");
    }
    public static double h( double a, double b)
    {
        return (a)/(Math.Pow(b,2)+1)+(1.0)/(Math.Pow(a,2)+Math.Pow(b,2));
    }
}
