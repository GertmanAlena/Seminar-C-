// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

Double  SystemCoor(int Xa, int Ya, int Za, int Xb, int Yb, int Zb)
{
    return Math.Sqrt ((Xa - Xb) * (Xa - Xb) + (Ya - Yb) * (Ya - Yb) + (Za - Zb) * (Za - Zb));
}

    Console.WriteLine("введите координату Xa ");
    int X1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите координату Ya ");
    int Y1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите координату Za ");
    int Z1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("введите координату Xb ");
    int X2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите координату Yb ");
    int Y2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("введите координату Zb ");
    int Z2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(Math.Round(SystemCoor(X1, Y1, Z1, X2, Y2, Z2)));



