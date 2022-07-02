// // Метод 2 принимает и не возвращает

// void Metod2(string mass)
// {
//     Console.WriteLine("Hello, World!");
// }
// Metod2("text");


// Метод 2.1 принимает и не возвращает КОГДА НЕСКОЛЬКО АРГУМЕНТОВ

void Metod2(string mass, int count)
{
    int i = 0;
    while(i < count)
    {
        Console.WriteLine("Hello, World!");
        i++;
    }
}
// Metod2("text", 5);
Metod2(mass: "text", count: 5); /*или так*/