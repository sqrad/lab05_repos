// Lab5_2.cs
// <Возняк Едвард>
// Лабораторна робота № 5.2
// Обчислення суми ряду Тейлора за допомогою функцій
// Варіант 5
public class Lab5_2
{
    static void Main(string[] args)
    {
        double xp, xk, x, dx, eps, s = 0;
        int n = 0;
        Console.WriteLine("Enter xp value:");
        xp = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter xk value:");
        xk = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter dx value:");
        dx = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter eps value:");
        eps = double.Parse(Console.ReadLine());

        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("|{0,5} |{1,10} |{2,10} |{3,5} |", "x", "Log((1+x)/(1-x))", "S", "n");
        Console.WriteLine("-------------------------------------------------");

        x = xp;
        while(x <= xk)
        {
            S(x, eps, ref n,ref s);

            Console.WriteLine("|{0,5:F2} |{1,16:F5} |{2,10:F5} |{3,5} |", x, Math.Log((1.0 + x) / (1.0 - x)), s, n);

            x += dx;
        }
        Console.WriteLine("-------------------------------------------------");
    }
    //void function

    /*
    static void S(double x, double eps,ref int n, ref double s)
    {
        n = 0;
        double a = 2;
        s = a;
        do
        {
            n++;
            A(x, n, ref a);
            s += a;
        }while(Math.Abs(a)>=eps);
    }

    static void A(double x, int n, ref double a)
    {
        double R = (Math.Pow(x, 2 * n + 1) / (2 * n + 1));
        a *= R;
    }
    */

    //double function
    static double S(double x, double eps,ref int n, ref double s)
    {
        n = 0;
        double a = 2;
        s = a;
        do
        {
            n++;
            A(x, n, ref a);
            s += a;
        } while (Math.Abs(a) >= eps);
        return s;
    }
    public static double A(double x, int n, ref double a)
    {
        double R = (Math.Pow(x, 2 * n + 1) / (2 * n + 1));
        a *= R;
        return a;
    }
}
