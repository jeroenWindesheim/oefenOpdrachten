// See https://aka.ms/new-console-template for more information

// int[][] b = new int[3][];
// b[0] = new int[7];
// b[1] = new int[7];
// b[2] = new int[3];

int[][] b =
{
    new int[] { 21, 19, 17, 23 ,25, 25, 28 },
    new int[] { 27, 27, 25, 22, 20, 10, 20 },
    new int[] { 21, 23, 23 }
};

foreach (int[] item in b)
{
    foreach (int i in item)
    {
        Console.Write($"{i} ");
    }

    Console.WriteLine();
}