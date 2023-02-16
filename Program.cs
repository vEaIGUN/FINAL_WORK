string[] array1 = new string[] { "12", "muya", "," };
string[] array2 = new string[array1.Length];
void FullArray(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[i] = array1[i];
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}
FullArray(array1, array2);
PrintArray(array2);