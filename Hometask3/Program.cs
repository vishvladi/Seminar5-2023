// Задайте массив вещественных чисел. Найдите разницу между максимальным и 
//минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
int ReadInt(string message)
 {
    System.Console.Write(message);
    int inputedNum = Convert.ToInt32(Console.ReadLine());
    return inputedNum;
}
int[] GetArray(int len, int min, int max)//получение массива случайных чисел
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
    System.Console.Write($"{array[i]}, ");
    }
    System.Console.Write();// Для перевода строки
}