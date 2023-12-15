/* Задача 3 */

class Program
{
    static void PrintArray(int [] myArray, int i = 0)
    {
        if (i != myArray.Length)
        {
            PrintArray(myArray, i + 1);
            Console.WriteLine($"{myArray[i]} ");
        }
    }

    static void Main(string[] args)
    {
        int[] myArray = {1, 2, 5, 0, 10, 34};

        PrintArray(myArray);
    }
}


