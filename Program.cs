// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
//  лучше обойтись исключительно массивами.

string[] arr1 = new string[4] { "20", "Hellow", "Vasilisa", "20"};

string[] arr2 = new string[arr1.Length];

void SecondArr(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Lenght; i++)
    {
        if (arr1[i].Length <= 3)
        {  
            arr2[count] = arr1[i];
            count++;
        }
    }
}

void PrintArr(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

SecondArr(arr1, arr2);
PrintArr(arr2);