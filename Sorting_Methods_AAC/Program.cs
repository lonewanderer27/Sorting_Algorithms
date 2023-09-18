
// int[] swap(fNum) {
//     int[] newArray = originalArray;
//     return newArray;
// }

int[] bubbleSort(int[] originalArray, int order)
{
    int[] newArray = originalArray;
    return newArray;
}

int[] selectionSort(int[] originalArray, int order)
{
    int[] newArray = originalArray;
    return newArray;
}

int[] insertionSort(int[] originalArray, int order)
{
    int[] newArray = originalArray;
    return newArray;
}
        
int MAX_ARRAY = 0;
bool validMaxArray = false;

// get MAX_ARRAY from user
while (validMaxArray == false)
{
    Console.Write("Enter the amount of numbers: ");
    validMaxArray = Int32.TryParse(Console.ReadLine(), out MAX_ARRAY);

    if (validMaxArray == false)
    {
        Console.WriteLine("Invalid Number");
    }
    else
    {
        break;
    }
}

// initialize an array with a size based on MAX_ARRAY value
int[] numbers = new int[MAX_ARRAY];

// ask the user
for (int i = 0; i < MAX_ARRAY; i++)
{
    Console.Write("Number [" + (i+1) + "]: ");
    numbers[i] = Int32.Parse(Console.ReadLine());
}

// ask if ascending or descending
bool validOrder = false;
int order = 0; 
while (order != 1 || order != 2)
{
    Console.Write("Enter [ 1 ] for ascending, [ 2 ] for descending: ");
    Int32.TryParse(Console.ReadLine(), out order);
    if (order == 1 || order == 2)
    {
        validOrder = true;
        break;
    }
    else
    {
        Console.WriteLine("Invalid choice! ");
    }
}

// display the original array of numbers
Console.WriteLine("\nOriginal Array: ");
foreach (var number in numbers)
{
    Console.Write(number + ", ");
}
// display on what way it was sorted
Console.Write("\nSorted: ");
if (order == 1)
{
    Console.WriteLine("ascending");
}
else
{
    Console.WriteLine("descending");
}