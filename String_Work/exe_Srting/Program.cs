// В заданной строке текста определите количество слов. 
// Каждое слово отделено друг от друга пробелом.
// Console.WriteLine("press something");
// string line = Console.ReadLine();
// string probel = " ";
// int i, kolslov = 1, kolbukv = 0;
// for (i = 0; i != line.Length; i++)
// {
//    if (line[i] != probel[0]) 
//       kolbukv++;
//    else
//       kolslov++;
// }
// Console.WriteLine("your message is: " + line);
// Console.WriteLine("slova {0} bukvi {1}", kolslov, kolbukv);
// Console.ReadKey();

// string[] arrString; //объявляем массив
// arrString = new string[size]; //выделяем память для массива size – количество строк (экземпляров) типа string.

// string[] daysOfWeek = {"Sunday", "Monday", "Tuersday",
//       "Wednesday", "Thirsday", "Friday", "Saturday" };
        
//         for(int i = 0; i < daysOfWeek.Length; i++)
//         Console.WriteLine("AS[{0}] = {1}", i, daysOfWeek[i]);
//         Console.ReadKey();

                                                        // Ввод строк с клавиатуры  ***     ***
                                                    // и образование нового массива

      // 1. Объявление переменных
      string[] AS; // ссылка на массив строк
      int count; // текущее количество строк в массиве
      string s;
      string[] AS2; // дополнительная переменная-ссылка - сохраняет старый массив строк

      // 2. Цикл ввода строк
      Console.WriteLine("Enter strings:");

      count = 0; // обнулить количество строк
      AS = new string[count]; // выделить память для 0 строк

      do
      {
        // Ввести строку
        s = Console.ReadLine();

        // Проверка, пустая ли строка
        if (s!="")
        {
          // если строка не пустая, то добавить строку в массив
          count++;

          // предварительно выделить память для нового массива
          // в котором на 1 элемент больше
          AS2 = new string[count];

          // скопировать старый массив в новый
          for (int i = 0; i < AS2.Length - 1; i++)
            AS2[i] = AS[i];

          // добавить последнюю введенную строку в массив AS2
          AS2[count - 1] = s;

          // Освобождать память, предварительно выделенную под AS не нужно,
          // этим занимается сборщик мусора

          // перенаправить ссылку AS на AS2
          AS = AS2;
        }
      } while (s != "");

      // 3. Вывод массива строк AS в цикле
      for (int i = 0; i < AS.Length; i++)
        Console.WriteLine("AS[{0}] = {1}", i, AS[i]);
      Console.ReadKey();
