int[] array = new int[10];
int num = 0;
for(int i = 0; i<array.Length; i++)
{
    array[i] = new Random().Next(1,101);
    Console.Write(array[i] + " ");
    if(array[i] > 19  && array[i] < 92)
    {
num = num + 1;
    }
}
Console.WriteLine();
Console.Write(num);