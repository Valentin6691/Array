// Задача 1: Задайте одномерный массив из 10 целых
//чисел от 1 до 100. Создайте зеркальный массив. 

int[] array = new int[10];
Console.Write("Массив {");
for(int i = 0; i<9; i++)
{
    array[i] = new Random().Next(1,100);
    Console.Write(array[i] + ", ");
}
array[9] = new Random().Next(1,100);
    Console.Write(array[9] + "}");
Console.WriteLine();
Console.Write("Зеркальный массив {" + array[9]);
int n = 0;
for(int i = 1; i<array.Length; i++)
{
    n = array.Length - i - 1;
    Console.Write(", " + array[n]);
}
Console.Write("}");