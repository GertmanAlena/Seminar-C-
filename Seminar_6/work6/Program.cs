// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Febonachi(){

    int amountNumberts = 12;
    int number1 = 0;
    int number2 = 1;
    Console.Write($"{number1}, {number2}, ->");
    for (int i = 0; i < amountNumberts; i++)
    {
        
        int NextNumber = number1 + number2;
        number1 = number2;
        number2 = NextNumber;
        Console.Write($" {NextNumber}, ");
    }
}
Febonachi();