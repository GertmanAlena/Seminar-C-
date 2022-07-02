// В тексте все пробелы заменить черточками, все маленькие "к" заменить "К", а большие "С" заменить маленькими "с"

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы Вас послали вместо нашего милого Виценгероде, "
            + " Вы бы взяли приступом согласие прусского короля. "
            + " Вы так красноречивы. Вы дадите мне чаю?";

// string s = qwerty
//            012345
// s[3] = r

string Replasy (string text, char oldValue, char newValue)
{
    string result = String.Empty;  /*1..сразу задаём начальную пустую строку*/
    int length = text.Length; /*3..обращаемся к свойству, показывающему количество символов в строке*/
    for(int i = 0; i < length; i++)  /*4..меняем буквы переходя по индексам*/
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    
    return result; /*2..вторым действием возвращаем заполненную строку далее пишем сам код*/
}
string newText = Replasy(text, ' ', '|'); /*пишем что на что мы меняем и передаем в наш метод*/
Console.WriteLine(newText);
Console.WriteLine(); /*пустая строка*/

newText = Replasy(newText, 'к', 'К'); /*пишем что на что мы меняем и передаем в наш метод*/
Console.WriteLine(newText);
Console.WriteLine(); /*пустая строка*/

newText = Replasy(newText, 'с', 'С'); /*пишем что на что мы меняем и передаем в наш метод*/
Console.WriteLine(newText);
