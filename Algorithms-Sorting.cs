//Sorting-insertionSort1

public static void insertionSort1(int n, List<int> arr)
    {
    for (int i = 1; i < n; i++)
        {
            int key = arr[i];      // element to insert
            int j = i - 1;

            // Shift elements greater than key to the right
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j--;
                Console.WriteLine(string.Join(" ", arr));
            }

            // Insert key at correct position
            arr[j + 1] = key;
            
            
        }
        Console.WriteLine(string.Join(" ", arr));
        
    }

}


//Counting-Sort1
public static List<int> countingSort(List<int> arr)
    {
        // Frequency array of size 100
        int[] freq = new int[100];

        // Count occurrences
        foreach (int num in arr)
        {
            freq[num]++;
        }

        // Convert to List<int> for return
        return new List<int>(freq);
    }
