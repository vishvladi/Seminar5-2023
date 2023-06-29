// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
double[] GetArray()//получение массива случайных чисел
{
    double[] array = new double [5];
    Random random = new Random();
    for (int i = 0;i < array.Length; i ++)
    {
        array[i] = random.Next(0, 100) + random.NextDouble();
    }
    return array;
}
void PrintArray(double[] array)
{   
    System.Console.WriteLine($"Числа в массиве: ");
    for (int i = 0; i < array.Length; i ++)
    {
    System.Console.Write($"\t {array[i]:f3}  ");
    }
    System.Console.WriteLine();// Для перевода строки
}
double Max(double[] array)
{
    double max = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
double Min(double[] array)
{
    double min = array[0];
    for (int i = 0; i < array.Length; i ++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
        
    }
    return min; 
}
double[] newarray = GetArray();
PrintArray(newarray);
double max = Max(newarray);
double min = Min(newarray);
System.Console.WriteLine($"Максимальное число: {max:f3} \n Минимальное число: {min:f3} \nРазница между максимальным и минимальным числами равна {max - min:f3}");