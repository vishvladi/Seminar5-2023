// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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
int SumOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}
int length = ReadInt();
int[] NewArray = GenerateArray(length, 0, 100);
PrintArray(NewArray);
int oddsum = SumOddPosition(NewArray);
System.Console.WriteLine($"Сумма чисел на нечетных позициях: {oddsum}");
