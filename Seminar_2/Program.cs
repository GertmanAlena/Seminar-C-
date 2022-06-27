// Программа выводит случацное число из отрезка [10,99] и показыввает большую цифру этого числа

int number = new Random().Next(10, 100);

int num1 = number / 10;
int num2 = number % 10;

if(num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}
Console.WriteLine(number +" " + num1 + " " + num2);
