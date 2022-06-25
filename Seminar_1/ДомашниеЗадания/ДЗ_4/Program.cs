// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

Console.WriteLine("Input number ");
int Number = Convert.ToInt32(Console.ReadLine());

int FirstNumber = 1;
Console.Write(Number + "->");

while(FirstNumber <= Number) 
{
    if(FirstNumber <= Number)
        if(FirstNumber %2 ==0)
            {
                Console.Write(FirstNumber + ", ");
                FirstNumber++;
            }
    else
    {
       FirstNumber++;
    }
 }




