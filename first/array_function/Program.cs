/*Было: 6 8 3 2 1 4 5 7
Стало: 1 8 3 2 6 4 5 7 */

/* int [] arr = {2, 4, 3, 9, 5, 3, 8, 7};
void PrintArray(int [] array) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write( $"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
      int minPosition = i;
      for (int j = i + 1; j < array.Length; j++)
      {
        if (array[j] < array[minPosition])
        {
          minPosition = j;  
        }
      }
      int temporary = array [i];
      array[i] = array[minPosition];  
      array[minPosition] =temporary;   
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr); */

int [] arr = {2, 4, 13, 9, 25, 3, 8, 7, 23};
void PrintArray(int [] array) 
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write( $"{array[i]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int [] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
      int maxPosition = i;
      for (int j = i + 1; j < array.Length; j++)
      {
        if (array[j] > array[maxPosition])
        {
          maxPosition = j;  
        }
      }
      int temporary = array [i];
      array[i] = array[maxPosition];  
      array[maxPosition] =temporary;   
    }
}
PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);