// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// void rundomNumber(int A, int B){
// int number = new Random().Next(A, B+1);

// // int number = new Random().Next(1, 100000);
// int min = 100;
// int max = 999;
// int SecondMax = 9999;

// if(number > min && number < max)
// {
//     int reduce = number % 10;
//     Console.WriteLine(number + "->" + reduce);
// }

//     else if(number > max && number <= SecondMax)
//     {
//         int Div = number / 10;
//         int Find = Div % 10;
//         Console.Write(number + "->" + Find);
//     }
//             else if(number < min)
//             {
//                 Console.Write(number + "->" + "третьей цифры нет");
//             }
// else
// {
//     int bigNumber = number / 100;
//     int Lot = bigNumber % 10;
//     Console.WriteLine(number + "->" + Lot);
// }
// }
// Console.Write("Введите минимальное число диапазона ");
// int start = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное число диапазона до 99999 ");
// int end = Convert.ToInt32(Console.ReadLine());
// rundomNumber(start, end);


int Number = new Random().Next(1, 100000);
Console.Write(Number + "->");
int max = 999;
int Div = 0;
int Div2 = 0;
int max2 = 99;


for(Div = 999; Number > max; Number / 10);

