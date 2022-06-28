int x = 5421;
int a = x % 10;
int b = x / 10 % 10;
int c = x / 100 % 10;
int d = x / 1000;
x = a * 1000 + b * 100 + c * 10 + d;
Console.WriteLine(x == 1);
