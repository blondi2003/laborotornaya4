class Program
{
    static double Method(double k)
    {
        double m = Math.Pow(k, 2) / 5.0;
        return m;
    }
    static double Result(double k)
    {
        if (k < 1.0)
        {
            return 0;
        }
        else
        {
            return Method(k) + Result(k - 1);
        }

    }

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        double m = Result(n);

        Console.WriteLine(m);
        Console.ReadKey();
    }
}
