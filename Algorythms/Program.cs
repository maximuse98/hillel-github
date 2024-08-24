//1. Сортування массиву
//2. Пошук елементу в массиві

// Складність алгоритму:
// 1. Розмір масиву n
// 2. Розташування елементів масиву - середній сценарій

// O(n) - лінійна складність
// O(n^2) - квадратична складність
// O(log n) - логарифмічна складність

int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
int searchValue = 5;

// Складність O(n)
for (int i = 0; i < array.Length; i++)
{
    if (array[i] == searchValue)
    {
        Console.WriteLine($"Element found at index {i}");
        break;
    }
}

int[] array2 = { 8, 15, 24, 25, 46, 50, 99, 154, 155 };
int searchValue2 = 99;

// Бінарний пошук
// Складність О(n/2)
int middle;
int left = 0;
int right = array2.Length - 1;

while (left <= right)
{
    middle = (left + right) / 2;
    if (array2[middle] == searchValue2)
    {
        Console.WriteLine($"Element found at index {middle}");
        break;
    }
    else if (array2[middle] < searchValue2)
    {
        left = middle + 1;
    }
    else
    {
        right = middle - 1;
    }
}

if (left > right)
{
    Console.WriteLine("Element not found");
}


// Сортування масиву бульбашкою
int[] array3 = { 8, 15, 24, 25, 46, 50, 99, 154, 155, 1, 2, 3, 4, 5, 6, 7, 9, 10 };

// Складність О(n^2)
// найлегший випадок - O(n)

int right2 = 1;
bool isSorted = false;
int temp;

while (!isSorted)
{
    isSorted = true;
    for (int i=0; i < array3.Length - right2++; i++)
    {
        if (array3[i] > array3[i + 1])
        {
            // Поміняти місцями
            temp = array3[i];
            array3[i] = array3[i + 1];
            array3[i + 1] = temp;

            isSorted = false;
        }
    }
}