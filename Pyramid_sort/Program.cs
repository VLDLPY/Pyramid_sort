int[] arr = { 10, 20, 15, 30, 5, 75, 40 };

Console.WriteLine("Not sorted array: ");
PrintArray(arr);
HeapSort(arr);
Console.WriteLine("Sorted array: ");
PrintArray(arr);
WriteArrayToFile(arr, "sorted_array.txt");
void HeapSort(int[] arr)  //Метод HeapSort реализует сам алгоритм пирамидальной сортировки.
{
    int n = arr.Length;
    for (int i = n / 2 - 1; i >= 0; i--)
    Heapify(arr, n, i);
    for (int i = n - 1; i >= 0; i--)
    {
        int temp = arr[0];
        arr[0] = arr[i];
        arr[i] = temp;
        Heapify(arr, i, 0);
    }
}

void Heapify(int[] arr, int n, int i) //Метод Heapify выполняет перестановку элементов, чтобы привести их к пирамидальному виду.
{
    int largest = i;
    int l = 2 * i + 1;
    int r = 2 * i + 2;

    if (l < n && arr[l] > arr[largest]) 
    {
        largest = l;
    }

    if (r < n && arr[r] > arr[largest]) 
    {
        largest = r; 
    }

    if (largest != i)
    {
        int swap = arr[i];
        arr[i] = arr[largest];
        arr[largest] = swap;
        Heapify(arr, n, largest);
    }
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; ++i)
        Console.Write(arr[i] + " ");
        Console.WriteLine();
}
void WriteArrayToFile(int[] arr, string fileName)
{
    using (StreamWriter sw = new StreamWriter(fileName))
    {
        for (int i = 0; i < arr.Length; ++i)
        {
            sw.WriteLine(arr[i]);
        }
    }
}