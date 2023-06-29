//  Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2
int ReadInt()
 {
    System.Console.Write("Задайте длину массива: ");
    string text = Console.ReadLine();
    int inputedNum = Convert.ToInt32(text);
    return inputedNum;
}
int[] GenerateArray(int len, int min, int max)//получение массива случайных чисел
{
    int[] array = new int [len];
    Random random = new Random();
    for (int i = 0;i < array.Length; i ++)
    {
        array[i] = random.Next(min, max + 1);
    }
    return array;
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i ++)
    {
    System.Console.Write($"{array[i]}  ");
    }
    System.Console.WriteLine();// Для перевода строки
}
int CountEvens(int[] array)//подсчет четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i ++)
    {
        if(array[i] % 2 == 0)
        {
            count ++;
        }
    }
    return count;
}
int num = ReadInt();
int[] NewArray = GenerateArray(num,100,999);
int evensnumber = CountEvens(NewArray);
PrintArray(NewArray);
System.Console.WriteLine($"Количество четных чисел в массиве:  {evensnumber}");