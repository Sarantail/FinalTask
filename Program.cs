//Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string[] Array;
Console.WriteLine("Введите массив строк через пробел");
string ArrString = Console.ReadLine();
Array = ArrString.Split(' ');
var result = new string[Array.Length];
var index = 0;
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        result[index] = Array[i];
        index++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
PrintArray(result);