class Program
{
    static void Main(string[] args)
    {

        int x = Convert.ToInt32(Console.ReadLine());
        int y = Convert.ToInt32(Console.ReadLine());

        int c = ResInt(x, y);

        Console.WriteLine(c);


        double m = double.Parse(Console.ReadLine());
        double n = double.Parse(Console.ReadLine());

        double f = ResDouble(m, n);

        Console.WriteLine(f);


        char v = char.Parse(Console.ReadLine());
        char d = char.Parse(Console.ReadLine());

        int s = ResChar(v, d);

        Console.WriteLine(s);


        static int Result1(int x)
        {
            int g = 10 * x - 2;
            return g;
        }
        static int Result2(int y)
        {
            double w = -2 * Math.Exp(y);
            int g = (int)w;
            return g;
        }
        static int ResInt(int x, int y)
        {
            int a = Result1(x);
            int b = Result2(y);
            int g = Math.Max(a, b);
            return g;
        }


        static double ResD1(double m)
        {
            double g = 10 * m - 2;
            return g;
        }

        static double ResD2(double n)
        {
            double g = -2 * Math.Exp(n);
            return g;
        }

        static double ResDouble(double m, double n)
        {
            double a = ResD1(m);
            double b = ResD2(n);
            double g = Math.Max(a, b);
            return g;
        }


        static int R1(char v)
        {
            int g = 10 * v - 2;
            return g;
        }
        static int R2(char d)
        {
            double p = -2 * Math.Exp(d);
            int g = (int)p;
            return g;
        }


        static int ResChar(char v, char d)
        {
            int c = R1(v);
            int q = R2(d);
            int g = Math.Max(c, q);
            return g;
        }
    }
}
