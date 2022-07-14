// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

// void Febonachi(){

//     int amountNumberts = 12;
//     int number1 = 0;
//     int number2 = 1;
//     Console.Write($"{number1}, {number2}, ->");
//     for (int i = 0; i < amountNumberts; i++)
//     {

//         int NextNumber = number1 + number2;
//         number1 = number2;
//         number2 = NextNumber;
//         Console.Write($" {NextNumber}, ");
//     }
// }
// Febonachi();

// ***   ***   ***
// Напишите программу, которая будет создавать копию 
// заданного массива с помощью поэлементного копирования.


    // int[] myArray1 = new int[5];

    // for (int i = 0; i < 5; i++)
    // {
    //     myArray1[i] = new Random().Next(1, 100);

    //     int[] myArray2 = new int[5];
    //     Console.Write(myArray1[i]);

    //     for (int j = 0; j < myArray1.Length; j++)
    //     {
    //         myArray2[i] = myArray1[i];
    //         Console.Write(myArray2[i]);
    //     }
       
    // }
int[] myMass1 = array1();
int[] array1(){

    int[] myArray1 = new int[5];
    for (int i = 0; i < 5; i++)
    {
        myArray1[i] = new Random().Next(1, 100);
    }
    return myArray1;
}

void ShowArray1(int[] massive){
    for (int i = 0; i < massive.Length; i++)
    {
        Console.Write($"{massive[i]}, ");
    }
}
ShowArray1(myMass1);

