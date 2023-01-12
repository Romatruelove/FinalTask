string[] CreateArray(int count)
{
    string[] array = new string[count];
    Console.WriteLine($"Введите {count} элементов массива (каждый с новой строки):");
    for (int i = 0; i < count; i++)
    {
        array[i] = Console.ReadLine();
    }
    for (int j = 0; j <= count; j++)
    {
        if (j == 0) Console.Write($"[{array[j]}, ");
        else if (j == count - 1) Console.Write($"{array[j]}]");
        else if (j < count - 1) Console.Write($"{array[j]}, ");
    }
    Console.WriteLine();
    return array;
}

string[] ThreeSymbolsArray(string[] array)
{
    int arLength = 0;
    foreach (var el in array)
    {
        if (el.Length <= 3)
            arLength++;
    }

    string[] result = new string[arLength];
    int i = 0;
    foreach (var el in array)
    {
        if (el.Length <= 3)
        {
            result[i] = el;
            i++;
        }
    }


    if (result.Length < 1) Console.WriteLine("[]");
    else
    {
        Console.Write("[");
        for (int j = 0; j <= result.Length; j++)
        {
            if (j == 0) Console.Write($"{result[j]}, ");
            else if (j == result.Length - 1) Console.Write($"{result[j]}");
            else if (j < result.Length - 1) Console.Write($"{result[j]}, ");
        }
        Console.Write("]");
    }
    return result;
}

try
{
    Console.WriteLine($"Введите количество элементов в массиве:");
    int count = Convert.ToInt32(Console.ReadLine());

    string[] createdNewAr = CreateArray(count);
    Console.WriteLine();
    Console.WriteLine("Новый массив из трехзначных (и менее трех знаков) элементов: ");
    string[] threeSymbolsAr = ThreeSymbolsArray(createdNewAr);
    Console.WriteLine();
}
catch
{
    Console.WriteLine("Введите число");
}