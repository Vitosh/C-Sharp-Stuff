//Rule number one - be prepared :)

public static List<int> ReadLineAndParseToList()
{
    return Console.ReadLine().Split().Select(int.Parse).ToList();
}

static int[] ReadLineAndParseToArray()
{
    return Console.ReadLine().Split().Select(int.Parse).ToArray();
}

public static int[,] TransposeMaxtrix(int[,] matrix)
{
    int w = matrix.GetLength(0);
    int h = matrix.GetLength(1);

    int[,] result = new int[h, w];

    for (int i = 0; i < w; i++)
    {
        for (int j = 0; j < h; j++)
        {
            result[j, i] = matrix[i, j];
        }
    }
    return result;
}
