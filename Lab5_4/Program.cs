// // Lab5_4.cs
// <Возняк Едвард>
// Лабораторна робота № 5.4
// Обчислення сум та добутків за допомогою рекурсії
// Варіант 5
public class Lab5_4
{
    static void Main(string[] args)
    {
        int K = 1; 
        int N = 15;

        Console.WriteLine($"(iter)          P0 = {P0(K, N)}");
        Console.WriteLine($"(rec up ++)     P1 = {P1(K, N, K)}");
        Console.WriteLine($"(rec up --)     P2 = {P2(K, N, N)}");
        Console.WriteLine($"(rec down ++)   P3 = {P3(K, N, K, 1)}");
        Console.WriteLine($"(rec down --)   P4 = {P4(K, N, N, 1)}");
    }
    public static double P0(int K, int N)
    {
        double p = 1;
        for (int i = K; i <= N; i++)
            p *= (Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1.0 / i), 2)) / Math.Pow(i, 2);
        return p;
    }
    public static double P1(int K, int N, int i)
    {
        if(i>N)
            return 1;
        else
            return (Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1.0 / i), 2)) / Math.Pow(i, 2) * P1(K,N,i+1);
    }
    public static double P2(int K, int N, int i)
    {
        if(i<K)
            return 1; 
        else
            return (Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1.0 / i), 2)) / Math.Pow(i, 2) * P2(K, N, i - 1);
    }
    public static double P3(int K, int N, int i, double t) 
    {
        t *=  (Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1.0 / i), 2)) / Math.Pow(i, 2);
        if(i>=N)
            return t;
        else
            return P3(K, N, i+1, t);
    }
    public static double P4(int K, int N, int i, double t)
    {
        t *=  (Math.Pow(Math.Sin(i), 2) + Math.Pow(Math.Cos(1.0 / i), 2)) / Math.Pow(i, 2);
        if (i <= K)
            return t;
        else
            return P4(K, N, i - 1, t);
    }
}
