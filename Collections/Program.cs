// посилання
int number;
int[] numbers;

int x = 10;

int[] xx = new int[10];
int[] x1 = new int[2] { 10, 15};
int[] x2 = new int[] { 123, 1233, 35432, 222 };
int[] x3 = { 15, 23, 45, 89, 12 };
int[] x4 = [1, 2, 3, 4, 5, 6, 7, 8];

x1[0] = 100;
Console.WriteLine(x1[0]);

int k = x1[1];

string arrayVal = x1[1].ToString();
Console.WriteLine(arrayVal);

Console.WriteLine(x1.ToString());

x1[2 - 1] = 1000;
//x[-1] = 50;

// Index out of bounds
//x1[5] = 45;

//int ii = -1;
//x1[ii] = 100;

for (int i = 0; i < x4.Length; i++)
{
    Console.Write($"{x4[i]} ");
}
Console.WriteLine();

for (int i = x4.Length - 1; i >= 0; i--)
{
    Console.Write($"{x4[i]} ");
}
Console.WriteLine();

// багатовимірний масив
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[3] { 1, 2, 3 };
jaggedArray[1] = new int[6] { 4, 5, 6, 0, 55, 45 };
jaggedArray[2] = new int[3] { 7, 8, 9 };

for (int i = 0; i < jaggedArray.Length; i++)
{
    Console.Write("| ");
    for (int j = 0; j < jaggedArray[i].Length; j++)
    {
        Console.Write($"{jaggedArray[i][j]} ");
    }
    Console.Write("|");
    Console.WriteLine();
}

int[][][] y1 = new int[3][][];

int[,] array2D = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
int[,,] array3D = new int[3, 3, 3]
    { { { 1,2,3}, { 4,5,6}, { 7,8,9} },
      { { 10,11,12 }, { 13,14,15 }, { 16,17,18} },
      { { 19,20,21 }, { 22,23,24 }, { 25,26,27} } };

Console.WriteLine(array3D.Length);
Console.WriteLine(array3D[1,2,2]);

foreach (int v1 in x4)
{ 
    Console.Write($"{v1} ");
}

foreach (int[] arr in jaggedArray)
{
    foreach (int item in arr)
    {
        Console.Write($"{item} ");
    }
}