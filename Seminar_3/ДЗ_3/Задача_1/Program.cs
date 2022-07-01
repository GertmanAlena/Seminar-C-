// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.


void Start(){
int RandomNumber = new Random().Next(10000, 100000);

Console.Write(RandomNumber + "-> ");

int num1 = RandomNumber % 10;
int num2 = RandomNumber / 10 % 10;
int num3 = RandomNumber / 100 % 10;
int num4 = RandomNumber / 1000 % 10;
int num5 = RandomNumber / 10000; 

int polindromes = num1 * 10000 + num2 * 1000 + num3 * 100 + num4 * 10 + num5;
Console.Write(polindromes + "-> ");
if(RandomNumber == polindromes)
{
    Console.Write("Yes");
}
else
Console.Write("No");
}
Start();



