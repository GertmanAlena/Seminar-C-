// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void rundomNumber(int start, int finish)
{
    int number = new Random().Next(start, finish+1);
    int FerstNumber = number / 10;
    int SecondNumber = FerstNumber % 10;
    Console.Write(number + " -> " +  SecondNumber);
}
0
Console.Write("Введите минимальное число диапазона от 100 до 1000 ");
int startNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число диапазона от 100 до 1000 ");
int endNumber = Convert.ToInt32(Console.ReadLine());

rundomNumber(startNumber, endNumber);

int rundomNumber()
