// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)

Console.Write("Input a ");
int a = Convert.ToInt32(Console.ReadLine());

if(a%2 == 0)
Console.WriteLine(a + "->" + "Yes");
else
Console.WriteLine(a + "->" + "No");

