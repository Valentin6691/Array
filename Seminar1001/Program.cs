int[] array = new int[12];

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());

bool isFinde = false;

for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0,4);
    Console.Write(array[i] + " ");

    if(array[i] == num)
    {
        isFinde = true;
    }
    
}

if(isFinde == true)
{
    Console.WriteLine("Да");
}
else
{
     Console.WriteLine("Нет ");
}