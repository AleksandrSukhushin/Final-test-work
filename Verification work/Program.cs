// Задача. Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше, либо равна 3 символа. Первоначальный массив можно ввести с
// клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется
// пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)" -> ["2", ";-)"]
// ["1234", "1567", "-2", "comruter science"] -> ["-2"]
// ["Russia", "Denmark", "Kazan"] -> [ ]

Console.Clear();

Console.Write("Количество элекментов исходного массива: ");
int amount = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine();

string[] arrayInitial = new string[amount];
for (int i = 0; i < amount; i++)
{
    Console.Write($"Введите элемент {i+1}: ");
    string element = Convert.ToString(Console.ReadLine()!);
    arrayInitial[i] = element;
}

string[] arrayFinal = new string[amount];
int k = 3;
int index = 0;
for (int j = 0; j < amount; j++)
{
    if (arrayInitial[j].Length <= k)
    {
        arrayFinal[index] = arrayInitial[j];
        index++;
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine();
PrintArray(arrayFinal);
