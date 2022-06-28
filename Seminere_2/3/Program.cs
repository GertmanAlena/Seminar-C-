// тоже что и 2 задача, только с методом

void rundomnumber(){
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
}
for (int i = 0; i < 5; i++)
rundomnumber();