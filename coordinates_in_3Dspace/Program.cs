double GetValue(string msg)
{
    Console.WriteLine(msg);
    double value = double.Parse(Console.ReadLine());
    return value;
}

double GetPow(double a, double b, double c)
{
    double powInt = Math.Pow(a - b - c, 2);
    return powInt;

}

double GetSqrt(double a, double b)
{
    double sqrtInt = Math.Sqrt(a + b);
    return sqrtInt;
}

double x1 = GetValue("Введите первую координату по X");
double y1 = GetValue("Введите первую координату по Y");
double x2 = GetValue("Введите вторую координату по X");
double y2 = GetValue("Введите вторую координату по Y");
double x3 = GetValue("Введите третью координату по X");
double y3 = GetValue("Введите третью координату по Y");
Console.WriteLine(Math.Round(GetSqrt(GetPow(x1, x2, x3), GetPow(y1, y2, y3)), 2));