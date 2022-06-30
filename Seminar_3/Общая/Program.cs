// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y)


Console.WriteLine("Введите номер четверти ");
int quarter = Convert.ToInt32(Console.ReadLine());
Console.Write(quarter + "-> ");


if(quarter == 1)
    {
        Console.Write(" x>0" + " и" + " y>0 ");
    }

else if(quarter == 2)
    {
        Console.Write(" x<0 " + " и" + " y>0 ");
    }
else if(quarter == 3)
    {
        Console.Write(" x<0 " + " и" + " y<0 ");
    }
else
    {
        Console.Write(" x>0 " + " и" + " y<0 ");
    }
    

