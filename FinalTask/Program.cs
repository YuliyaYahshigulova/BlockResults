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

//string[] Array1 = {"Hello", "2", "world", ":-)"};
// string[] array = {"1234", "1567", "-2", "computer science"};

// int size = 3;

// string[] ShortArray(string[] array)
// {
//     int length = array.Length;
//     string[] shortarray = new string[length];
//     int count = 0;
//     for (int i = 0; i < length; i++)
//     {
//         if (array[i].Length <= size)
//         {
//             shortarray[count] = array[i];
//             count++;
//         }
//     }
//     Array.Resize(ref shortarray, count);
//     return shortarray;
// }
// void PrintArray (string[]array)
// {
//     int length = array.Length;
//     for (int i=0; i<length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }

// string[] shortarray = ShortArray(array);

////////
//
// using static System.Console;

// //Метод, который считывает строку с консли.

// string ReadString()
// {
//     WriteLine("Введите слова через пробел");
//     return ReadLine()!;
// }

// // Метод, который преобразует строку в массив строк.

// string[] StringToArray(string s)
// {
//     string[] stringArray = s.Split(" ");
//     return stringArray;
// }

//Метод, который создает массив только из элементов меньше трех символов. 

string[] array = {"Hello", "2", "world", ":-)"};

string[] ShortArray(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }
    string[] targetArray = new string[count];
    count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            targetArray[count] = array[i];
            count++;
        }
    }
    return targetArray;
}

//Метод печати массива.

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

//Решение.

// string str = ReadString();
// string[] array = StringToArray(str);
string[] targetArray = ShortArray(array);
PrintArray(targetArray);