internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int num = Convert.ToInt32(Console.ReadLine());
        int [] array = new int[3]; 
        if(num>99 && num<1000)
        {
array[0] = num%10;
array[1] = num%100/10;
array[2] = num/100;
for(int i = 0; i<array.Length; i++)
{
Console.Write(array[i] + " ");
}
        }
        else
        {
            Console.WriteLine("Число не подходит");
        }

    }
}