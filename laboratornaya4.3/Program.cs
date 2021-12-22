class Program
{
    static double Method(int k)
    {
        double m = (k + 1) / 13.0;
        return m;
    }

    static double Result(int k)
    {
        if (k == 1)
        {
            return Method(k);
        }
        else
        {
            return Method(k) * Result(k - 1);
        }
    }
    static void Main(string[] args)
    {
        int k = Convert.ToInt32(Console.ReadLine());
        double m = Result(k);
        Console.WriteLine(m);
        Console.ReadKey();
    }
}
