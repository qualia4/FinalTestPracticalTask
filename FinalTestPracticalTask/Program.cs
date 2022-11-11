Console.WriteLine("Enter your array:");
string[] array = Console.ReadLine().Split();
List<int> translated = translate(array);
Console.WriteLine("Sum:" + findSum(translated));
Console.WriteLine("Min:" + findMin(translated));
Console.WriteLine("Average:" + findAverage(translated));
Console.WriteLine("Max:" + findMax(translated));


List<int> translate(string[] array)
{
    List<int> result = new List<int>();
    for (int i = 0; i < array.Length; i++)
    {
        result.Add(Int32.Parse(array[i]));
    }
    return result;
}

int findSum(List<int> array)
{
    int result = 0;
    for (int i = 0; i < array.Count; i++)
    {
        result += array[i];
    }

    return result;
}

int findMin(List<int> array)
{
    int result = array[0];
    for (int i = 1; i < array.Count; i++)
    {
        if (array[i] < result)
        {
            result += array[i];
        }
    }

    return result;
}

int findMax(List<int> array)
{
    int result = array[0];
    for (int i = 1; i < array.Count; i++)
    {
        if (array[i] > result)
        {
            result = array[i];
        }
    }
    return result;
}

double findAverage(List<int> array)
{
    int sum = findSum(array);
    double result = sum / (array.Count);
    return result;
}