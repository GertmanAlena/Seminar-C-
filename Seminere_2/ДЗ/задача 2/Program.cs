// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

void FillArray ([] collection)
{
    int length = collection.length;
    int index = 0;
    while(index<length){
        collection[index] = new Random().Next();
        index++;
    }
}
void PrintArrey(int[] collection)
{
    
}