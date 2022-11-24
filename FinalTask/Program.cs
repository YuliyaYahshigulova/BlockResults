// Написать программу,которая из имеющегося массива строк 
// формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Пример:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []


// string[] array = {"1234", "1567", "-2", "computer science"};
// string[] array = {"Russia", "Denmark", "Kazan"};
string[] array = { "Hello", "2", "world", ":-)" };

string[] NewShortArray(string[] array)
{
    int count = 0;
    int size = 3;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            count++;
        }
    }
    string[] shortArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= size)
        {
            shortArray[count] = array[i];
            count++;
        }
    }
    return shortArray;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

string[] shortArray = NewShortArray(array);
PrintArray(shortArray);