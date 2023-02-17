// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double GetNumber(string message)
{
    double result = 0;
    
    while (true)
    {
        Console.WriteLine(message);
    
        if(double.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else 
        {
            Console.WriteLine("Ввели не число. Повторите ввод");
        }
    }
    return result;
}
(double, double) GetDotXAndY (double b1, double k1, double b2, double k2)
{
    double x = (b1 - b2) / (k2 - k1);
    double y = k2 * x + b2;

    return (x, y);
}

double b1 = GetNumber ("Введите значение b1");
double k1 = GetNumber ("Введите значение k1");
double b2 = GetNumber ("Введите значение b2");
double k2 = GetNumber ("Введите значение k2");

(double x, double y) = GetDotXAndY (b1, k1, b2, k2);
Console.WriteLine($"Точка перечечения прямых - ({x}, {y})");

