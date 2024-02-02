// --- Task #1 ---
void FindNaturNumbers(int M, int N)
{
    int min = M, max = N;
    if (min == max)
    {
        Console.WriteLine($"{max}. ");
        return ;
    }
    Console.Write($"{min}, ");
    min += 1;
    FindNaturNumbers(min, max);
}
Console.Clear();
Console.WriteLine("Task #1");
Console.Write("Введите начальное число M:");
int add_number_M = int.Parse(Console.ReadLine()!);
Console.Write("Введите конечное число N:");
int add_number_N = int.Parse(Console.ReadLine()!);

FindNaturNumbers(add_number_M, add_number_N);
Console.WriteLine();


// --- Task #2 ---
int fAnkerman(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    int result = m;
    for (int i = m; i< m + 2;i++)
    {
        result = fAnkerman(n - 1, result);
    }  
    return result;
}
Console.WriteLine("Task #2");
Console.Write("Введите число n:");
int number_n = int.Parse(Console.ReadLine()!);
Console.Write("Введите число m:");
int number_m = int.Parse(Console.ReadLine()!);
Console.WriteLine(fAnkerman(number_n, number_m));
Console.WriteLine();


// --- Task #3 ---
int[] CreateArray(int number_array, int max_number, int min_number)
{
    Random rand = new Random();
    int[] array = new int[number_array];
    for (int i = 0; i < number_array; i++)
    {
        array[i] = rand.Next(min_number, max_number);
    }
    return array;
}
void ToReversMass(int[] mass)
 {
    int[] mass_temp = mass;
    int i = mass.Length-1;
    if (i == 0)
    {
       Console.Write($"{mass[i]}");
       return;
    }
    Console.Write($"{mass[i]},");
    Array.Resize(ref mass_temp, mass_temp.Length - 1);
    ToReversMass(mass_temp);
 }

Console.WriteLine("Task #3");
Console.WriteLine("Введите количество элементов:");
int number_array = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите максимальное значение:");
int max_number = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите минимальное значение:");
int min_number = Convert.ToInt32(Console.ReadLine()!);

int[] array_create = CreateArray(number_array, max_number, min_number);
Console.WriteLine(String.Join(",", array_create));
ToReversMass(array_create);
