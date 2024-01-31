sealed class Array1 : BaseArray
{
    private int[] array;

    public Array1(int length, bool usInp = false)
    {
        array = new int[length];

        if (usInp)
        {

            ArrUsInp();
        }

        else
        {
            ArrRand();
        }
    }

    public override void ArrUsInp()
    {
        Console.WriteLine($"Введите {array.Length} чисел:");
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    public override void ArrRand()
    {
        Random random = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(1, 101);
        }

        Console.WriteLine("Рандомные значаения: ");
    }

    public override double CalculateAverage()
    {
        int sum = 0;
        foreach (int value in array)
        {
            sum += value;
        }
        return (double)sum / array.Length;
    }




    public override void PrintArray()
    {
        Console.WriteLine("Элементы массива:");
        foreach (int value in array)
        {
            Console.Write(value + " ");
        }
        Console.WriteLine();
    }

}