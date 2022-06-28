// покажет наибольшую цифру

int number = new Random().Next(10, 100);

Console.Write(number + " -> ");
if(number / 10 > number % 10)
{
    Console.WriteLine(number / 10);
}
else
{
    Console.WriteLine(number % 10);
}