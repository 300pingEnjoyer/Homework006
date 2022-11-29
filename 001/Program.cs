int [] CreateRandomArray(int size, int minValue,int maxValue) //min нижнее ограничение max верхнее ограничение
{
    int [] newArray = new int [size]; //тип массива int, выделяем память под тип int size штук

    for(int i=0;i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue + 1);
    }
    return newArray;
}

void ShowArray(int [] array)
{

    for(int i = 0;i < array.Length;i++ )
    {
        Console.Write (array[i]+" ");
    }
    Console.WriteLine();
}

int[] FindDigit(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count++;
        }
    }
     Console.WriteLine($"кол-во чисел больше 0 -> {count} ");
    return array;
}


Console.WriteLine("Введите размер массива");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное значение элемента");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение элемента");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(a, min, max);
ShowArray(myArray);
FindDigit(myArray);
