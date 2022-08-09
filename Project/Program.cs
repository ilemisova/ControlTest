string[] CreateStringArray(int size)
{
    string[] arrayX = new string[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} element: ");
        arrayX[i] = Convert.ToString(Console.ReadLine());
    }
    return arrayX;
}

string[] countElement(string[] arrayX)
{
    int count = 0;
    string[] newArray = new string[arrayX.Length];
    for (int i = 0; i < arrayX.Length; i++)
    {
        if (arrayX[i].Length <= 3)
        {
            newArray[count] = arrayX[i];
            count++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    for(int i =0; i<array.Length;i++)
    {
        Console.WriteLine($"{array[i]}");
    }
}

Console.WriteLine("Введите размер массива: ");
int element = Convert.ToInt32(Console.ReadLine());
string[] array = CreateStringArray(element);
string[] newArray = countElement(array);
Console.WriteLine("->");
PrintArray(newArray);
