Console.WriteLine("Введите a");
double a = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b");
double  b = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите c");
double c = Convert.ToDouble(Console.ReadLine());

double D;
D = (b * b) - (4 * a * c);
double D1 = Math.Sqrt(D);

if (D < 0)

{
    Console.WriteLine("Нет корней!");
}

else

{
    double x1 = (b * -1 + D1) / (2 * a);
    double x2 = (b * -1 - D1) / (2 * a);
    string a1 = Convert.ToString(x1);
    string a2 = Convert.ToString(x2);
    Console.WriteLine(a1);
    Console.WriteLine(a2);
}

