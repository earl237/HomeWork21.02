/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]
*/
Console.Clear();
int[] arr = new int[8];
Random rand = new Random();
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rand.Next(20);
    Console.Write(" ");
    Console.Write(arr[i]);
}
Console.Write("]");