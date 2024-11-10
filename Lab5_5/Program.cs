// Lab5_5.cs
// <Возняк Едвард>
// Лабораторна робота № 5.5
// Рекурсивні функції
// Варіант 5
public class Lab5_5
{
    public static int depth = 0;
    static int maxDepth = 0;
    public static int Q(int m, int n)
    {
        depth++;
        maxDepth = Math.Max(maxDepth, depth);

        int result;
        if (n == 1 || m == 1)
        {
            result = 1;
        }
        else if (m < n)
        {
            result = Q(n, m);
        }
        else if (m == n)
        {
            result = 1 - Q(m, m - 1);
        }
        else
        {
            result = Q(m, n - 1) + Q(m - n, n);
        }
            
        depth--;
        return result;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Enter m value:");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter n value:");
        int n = int.Parse(Console.ReadLine());

        try
        {
            int result = Q(m, n);

            Console.WriteLine($"Number of splits Q({m}, {n}) = {result}");
            Console.WriteLine($"Max recursion depth: {maxDepth}");
        }
        catch (StackOverflowException) 
        {
            Console.WriteLine("Error: Stack Overflow. Maybe values of m and n is too big.");
        }   
    }
}
