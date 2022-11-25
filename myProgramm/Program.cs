

void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
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
Console.WriteLine("ВВедите текст: ");
string[] array = Console.ReadLine().Split();
string[] array2 = new string[array.Length];
NewArray(array, array2);
Console.WriteLine();
Console.WriteLine("массив из строк длинна которых меньше либо ровна 3 символа: ");
PrintArray(array2);