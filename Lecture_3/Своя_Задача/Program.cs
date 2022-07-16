Console.Clear();

string text = "Изучаем массивы и функции, ";
string Replace (string text, char oldSimbol, char newSimbol, char oldSimbol2, char newSimbol2)
{
    string result = String.Empty;
    int length = text.Length;
    for(int i = 0; i < length; i++) 
        if(text[i] == oldSimbol) result = result + $"{newSimbol}";
        else if(text[i] == oldSimbol2) result = result + $"{newSimbol2}";
            else
            result = result + $"{text[i]}";
    return result;
}
string NewText = Replace(text, oldSimbol: 'а', newSimbol: 'А', oldSimbol2: 'у', newSimbol2: 'У');
Console.WriteLine(NewText);