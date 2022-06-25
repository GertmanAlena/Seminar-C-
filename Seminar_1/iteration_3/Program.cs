// выводим день недели по заданному числу

Console.Write("Input day ");

int day = Convert.ToInt32(Console.ReadLine());

// Monday = 1; Tuesday = 2; Wednesday = 3; Thursday = 4; Friday = 5; Saturday = 6; Sunday = 7;

if (day == 1)
{
    Console.Write("today is Monday");
}

else if (day == 2)
{
    Console.Write("today is Tuesday");
}

else if (day == 3)
{
    Console.Write("today is Wednesday");
}

else if (day == 4)
{
    Console.Write("today is Thursday");
}

else if (day ==5)
{
    Console.Write("today is Friday");
}

else if (day == 6)
{
    Console.Write("today is Saturday");
}

else if (day == 7)
{
    Console.Write("today is Sunday");
}
else Console.WriteLine("incorrect day");