//1 задание
/*
int n;

Console.WriteLine("Задайте размер матрицы:");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (n > 100)
{
    Console.WriteLine("Неверный размер матрицы:");
    n = Convert.ToInt32(Console.ReadLine());
}

int[,] matrix = new int[n, n];
int rows = matrix.GetUpperBound(0) + 1;
int columns = matrix.Length / rows;

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"Введите значение для элемента [{i}, {j}]: ");
        matrix[i, j] = Convert.ToInt32(Console.ReadLine());
    }
}

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
isMatrixSymmetric(matrix, rows, columns);

static bool isMatrixSymmetric(int[,] matrix, int rows, int columns)
{
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (matrix[i, j] != matrix[j, i])
            {
                Console.WriteLine("NO");
                return false;
            }
        }
    }
    Console.WriteLine("YES");
    return true;
}
*/

//2 Задание
/*
int days = Convert.ToInt32(Console.ReadLine());
int[] daysTemp = new int[days];

List<int> maxTemperature = new List<int>();
List<int> maxIndexes = new List<int>();
List<int> minTemperature = new List<int>();
List<int> minIndexes = new List<int>();

for (int i = 0; i < days; i++)
{
    int t = Convert.ToInt32(Console.ReadLine());
    daysTemp[i] = t;

}
int temporary = daysTemp[0];
for (int i = 1; i < daysTemp.Length - 2; i++)
{
    if (temporary < daysTemp[i] && daysTemp[i] > daysTemp[i + 1])
    {
        maxTemperature.Add(daysTemp[i]);
        maxIndexes.Add(i + 1);
    }
    if (temporary > daysTemp[i] && daysTemp[i] < daysTemp[i + 1])
    {
        minTemperature.Add(daysTemp[i]);
        minIndexes.Add(i + 1);
    }

    temporary = daysTemp[i];
}

for (int i = 0; i < maxTemperature.Count; i++)
{
    int index = maxIndexes[i];
    int temperature = maxTemperature[i];
    Console.WriteLine("day " + index + ": " + temperature + "(max)");
}

for (int i = 0; i < minTemperature.Count; i++)
{
    int index = minIndexes[i];
    int temperature = minTemperature[i];
    Console.WriteLine("day " + index + ": " + temperature + "(min)");
}
*/


int N = Convert.ToInt32(Console.ReadLine());
int[] nums = new int[N];

for (int i = 0; i < N; i++)
{
    int t = Convert.ToInt32(Console.ReadLine());
    nums[i] = t;
}

int index1 = 0;
int index2 = 0;

for (int i = 0; i < nums.Length; i++)
{
    for (int j = 0; j < nums.Length; j++)
    {
        if (nums[i] + nums[j] == 0)
        {
            index1 = i;
            index2 = j;
            break;
        }
    }
    if (index1 != 0 && index2 != 0)
    {
        break;
    }
}

Console.WriteLine(index1 + " " + index2);
