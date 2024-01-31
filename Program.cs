
internal class Program
    {

        static void Main(string[] args)
        {
            Array1 one = new Array1(4);
            BaseArray two = new Array1(3);

            Array2 three = new Array2(4, 4);
            BaseArray four = new Array2(4, 5);

            Array3 five = new Array3(4);
            BaseArray six = new Array3(5);
  
            BaseArray[] baseArrays = new BaseArray[6]
            {
                one, two, three, four, five, six
            };

            foreach(BaseArray item in baseArrays)
            {
                Console.WriteLine($"Среднее значение {item.GetType()} массива {item.CalculateAverage()}\n");
                Console.WriteLine($"Элементы массива {item.GetType()}\n");
                item.PrintArray();
            }
            Console.ReadLine();

        }
    }
