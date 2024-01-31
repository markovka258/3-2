sealed class Array2 : BaseArray
{
	private Random random;
	private bool fillWithUserInput;
	private int[,] array;

	public Array2(int rows, int columns, bool usInp = false)
	{
    	array = new int[rows, columns];
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
    	Console.WriteLine("Введите элементы матрицы через пробел: ");
        	for (int i = 0; i < array.GetLength(0); i++)
        	{
            	var line = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            	for (int j = 0; j < array.GetLength(1); j++)
            	{
                	array[i, j] = int.Parse(line[j]);
            	}
        	}
	}

	public override void ArrRand()
	{
    	Random random = new Random();

    	for (int i = 0; i < array.GetLength(0); i++)
        	{
            	for (int j = 0; j < array.GetLength(1); j++)
            	{
                	array[i, j] = random.Next(1, 100);
            	}
        	}

    	Console.WriteLine("Рандомные значаения: ");
	}


	public override void PrintArray()
	{
    	for (int i = 0; i < array.GetLength(0); i++)
    	{
        	for (int j = 0; j < array.GetLength(1); j++)
        	{
            	Console.Write(array[i, j] + " ");
        	}
        	Console.WriteLine();
    	}
	}
    
    	public override double CalculateAverage()
	{
    	double sum = 0;
    	for (int i = 0; i < array.GetLength(0); i++)
    	{
        	for (int j = 0; j < array.GetLength(1); j++)
        	{
            	sum += array[i, j];
        	}
    	}
    	return sum / (array.GetLength(0) * array.GetLength(1));
	}

}
