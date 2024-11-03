// Lab5_3.cs
// <Возняк Едвард>
// Лабораторна робота № 5.3
// Функції, що містять розгалуження та цикли з рекурентними співвідношеннями
// Варіант 5
public class Lab5_3
{
    static void Main(string[] args)
    {
        double rp, rk, z;
        int n;

        Console.WriteLine("Enter rp value:");
        rp = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter rk value:");
        rk = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter n value:");
        n = int.Parse(Console.ReadLine());

        double rg = (rk - rp) / n;

        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("|{0,5} |{1,10} |", "r", "z");
        Console.WriteLine("-------------------------------------------------");


        double r = rp;
        while (r <= rk)
        {
            z = h(r + 1) + Math.Pow(h(Math.Pow(r, 2) + 1), 2) + 1;
            Console.WriteLine("|{0,5:F2} |{1,10:F5} |", r, z);
            r += rg;
        }
        Console.WriteLine("-------------------------------------------------");
    }
    public static double h(double x)
    {
        if(Math.Abs(x)>=1)
            return (Math.Cos(x)+1)/(Math.Exp(x));
        else
        {
            double S = 0;
            int n = 0;
            double a = 1.0/Math.Sin(Math.Pow(x,2));
            S = a;
            do
            {
                n++;
                double R = Math.Pow(x, 4 * n + 2) / (2 * n - 1) * (2 * n) * (2 * n + 1);
                a *= R;
                S += a;
            } while (n < 6);
            return S;
        }
    }
}
