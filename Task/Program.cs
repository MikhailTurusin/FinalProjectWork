// Задача: Написать программу, которая
// 1. из имующегося массива строк формирует массив из строк,
// 2. длиная которых меньше либо равна 3 символа.
// 3. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// 4. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ";-)"] -> ["2", ";-)"]
// ["1234", "1267", "-2", "computer science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> []

Console.WriteLine("Введите слова массива:");
string[] array = IncomingTextArray(8, "");
PrintArray(array);
Console.Write(" -> ");
string[] newarray = NewArray(array);
PrintArray(newarray);

string[] NewArray(string[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) count++;
    }
    string[] newarr = new string[count];
    int j = 0;
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i].Length <= 3)
            {
                newarr[j] = arr[i];
                j++;
            }
        }
    }
    return newarr;
}

string[] IncomingTextArray(int size, string word)
{
    string[] arr = new string[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Console.ReadLine();
    }
    return arr;
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.Write("]");
}