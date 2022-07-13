// Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

Console.WriteLine("Введите K1 ");
double K1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b1 ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите K2 ");
double K2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите b2 ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (K1 == K2 && b1 != b2)
{
    Console.WriteLine("прямые параллельны ");
}
else if (b1 == b2 && K1 == K2)
{
    Console.WriteLine("прямые совпадают ");
}
else
{
    double x = (b2 - b1) / (K1 - K2);
    double y1 = K1 * x + b1;
    double y2 = K2 * x + b2;
    Console.WriteLine($" K1 = {K1}, K2 = {K2}, b1 = {b1}, b2 = {b2}");
    Console.WriteLine($" x = {x}, y1 = {y1}, y2 = {y2}");
}