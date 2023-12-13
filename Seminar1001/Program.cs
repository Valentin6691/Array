internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число");

        int num = Convert.ToInt32(Console.ReadLine());

        int array[] = new int[5];
        bool isFind = false;

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(0, 14);
            Console.Write(array(i) + " ");

            if (array(i) == num)
            {
                isFind = true;
                break;
            }
        }
        if (isFind == true)
        {
            Console.Write("Да" + num);
        }
        else
        {
            Console.Write("Нет");
        }
    }
}