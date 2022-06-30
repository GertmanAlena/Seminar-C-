// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(1, 100000);
int min = 100;
int max = 999;
int SecondMax = 9999;

if(number > min && number < max)
{
    int reduce = number % 10;
    Console.WriteLine(number + "->" + reduce);
}

    else if(number > max && number < SecondMax)
    {
        int Div = number / 10;
        int Find = Div % 10;
        Console.Write(number + "->" + Find);
    }
            else if(number < min)
            {
                Console.Write(number + "->" + "число двухзначное");
            }
else
{
    int bigNumber = number / 100;
    int Lot = bigNumber % 10;
    Console.WriteLine(number + "->" + Lot);
}
