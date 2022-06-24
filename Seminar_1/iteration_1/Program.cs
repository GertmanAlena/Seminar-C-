// Программа вывода квадрата числа

//Запрашиваем у пользователя число
Console.Write("Input number: ");

//Создаём переменную number и сохраняем её значение, введённое из консоли
int number = Convert.ToInt32(Console.ReadLine());

// объявляем переменную q и сохраняем в неё квадрат числа number
int q = (number * number);

//выводим значение
Console.WriteLine(number + "->" + q);
