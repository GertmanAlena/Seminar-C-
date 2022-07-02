// // метод 4 принимает и возвращает Например нужно несколько раз написать текст

// String Metod4(string text, int count)
// {
//     string result = string.Empty;
//     int i = 0;
//     while(i < count)
//     {
//     result = result + text;    
//     i++;
//     }
//     return result;
// }
// String res = Metod4("Hello ", 3);
// Console.WriteLine(res);

// метод 4 принимает и возвращает Например нужно несколько раз написать текст FOR

String Metod4(string text, int count)
{
    string result = string.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }    
    return result;
}
String res = Metod4("Hello ", 3);
Console.WriteLine(res);