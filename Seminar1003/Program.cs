Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

int [] array = new int[num];
int [] array2 = new int[num/2];

for(int i = 0; i<array.Length; i++)
{
array[i] = new Random().Next(-20, 30);
Console.Write(array[i] + " ");
}
Console.WriteLine();
for(int i = 0; i<array2.Length; i++)
{
array2[i] = array[i] * array[array.Length - 1 - i];
Console.Write(array2[i] + " ");
}