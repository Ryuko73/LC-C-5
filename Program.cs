void Zadacha1()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray(numbers);
    FindChet(numbers);
    PrintArray(numbers);
}
void FillArray(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(1, 100);
    }

}
void PrintArray(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(" " + numbers[i]);
    }
    Console.WriteLine();
}
void FindChet(int[] numbers)
{
    int Chet = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            Chet++;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"в массиве {Chet} четных чисел");
}
//Zadacha1();
void Zadacha2()
{
    int size = 12;
    int[] numbers = new int[size];
    FillArray2(numbers);
    FindNeChet2(numbers);
    PrintArray2(numbers);
}
void FillArray2(int[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.Next(1, 100);
    }

}
void PrintArray2(int[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(" " + numbers[i]);
    }
    Console.WriteLine();
}
void FindNeChet2(int[] numbers)
{
    int neChet = 0;
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (i % 2 == 0) ;
        else
        {
            sum = sum + numbers[i];
        }
        Console.WriteLine(sum);
    }
    Console.WriteLine();
    Console.WriteLine($"сумма элементов с нечётными индексами {sum}");
}
//Zadacha2();
void Zadacha3()
{
    int size = 12;
    double[] numbers = new double[size];
    FillArray3(numbers);
    FindMax(numbers);
    PrintArray3(numbers);
}
void FillArray3(double[] numbers)
{
    Random random = new Random();
    for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = random.NextDouble() * 100;
    }

}
void PrintArray3(double[] numbers)
{
    double max2 = 0;
    max2 = numbers[11] + numbers[0];
        for (int i = 0; i < numbers.Length; i++)
    {
        Console.Write(" " + numbers[i]);
        Console.WriteLine( );
    }
        Console.Write("разница между максимальным и минимальным элементов массива " + ((double)(max2)));

    Console.WriteLine();
}
void FindMax(double[] numbers)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        for (int j = 0; j < numbers.Length - 1 - i; j++)
        {
            if (Math.Abs(numbers[j]) > Math.Abs(numbers[j + 1]))
            {
                double max = numbers[j];

                numbers[j + 1] = numbers[j];
                numbers[j] = max;
            }
        }
    }
}
Zadacha3();



//    Random rnd = new Random();
//     double[] d = new double[30];
//     double max=0, min=100;
//     for (int i = 0; i<d.Length; i++ )  d[i] = rnd.Next(100);
//     for (int i = 0; i < d.Length; i++)
//     {
//         if (d[i] > max) max = d[i];
//         if (d[i] < min) min = d[i];
//     }

//        for (int i = 0; i < d.Length; i++) Console.Write(" "+d[i]);//выводим массив
//        Console.WriteLine();
//          Console.WriteLine("max:  " + max);
//          Console.WriteLine("min  " +min);
//          Console.WriteLine("Разница максимального и минимального:  "+(max - min));
//         Console.ReadKey();
