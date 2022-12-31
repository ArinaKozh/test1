
string[] InitArray(int size)
{
    string[] array = new string[size];
    for (int i =0; i < size; i++)
    {
        array[i] = GetElement($"Введите {i+1}-ый элемент ");
    } 
    return array;
}
void PrintArray(string[] array)
{
     for(int i = 0; i<array.Length;i++)
     {
        Console.Write($"{array[i]}  ");
     }
    Console.WriteLine();
}
int GetNumber(string message)
{
   int result = 0;
   bool isCorrect = false;

   while(!isCorrect)
   {

    Console.WriteLine(message);

    if (int.TryParse(Console.ReadLine(), out result) )
    {
        isCorrect = true;
    } 
    else
    {
        Console.WriteLine("Некорректно ввели число");
    }
   } 
   return result;
}
string GetElement(string message)
{
   string result = "";
   bool isCorrect = false;
   Console.WriteLine(message);
   result = Console.ReadLine();
   return result;
}
string[] NewArray(string[] mas)
{
    string[] result = new string[mas.Length];
    int j = 0;
    for(int i =0;i<mas.Length;i++)
    {
        if (mas[i].Length<4)
        {
            result[j] = mas[i];
            j++;
        }
    }
    return result;
}

int size = GetNumber("Введите количество элементов");
string[] mas = InitArray(size);
PrintArray(mas);
string[] NewMas = NewArray(mas);
PrintArray(NewMas);