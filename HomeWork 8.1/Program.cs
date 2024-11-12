using System;
class Program
{
    static void Main()
    {
        int[] array = new int[10];
        Random randomNumber = new Random();

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = randomNumber.Next(-10, 11);
        }
        Console.WriteLine("Elements with paired indexes:");
        for (int i = 0; i < array.Length; i += 2)
        {
            Console.WriteLine($"Index {i}: {array[i]}");
        }
        //Второе задание
        int sum = 0;
        foreach (int num in array)
        {
            sum += num;
        }
        if (sum >= 0)
        {
            Console.WriteLine("The sum of array elements is a non-negative number.");
        }
        else
        {
            Console.WriteLine("The sum of the elements of the array is a negative number.");
        }
    }
    void firstTwoDimensionalArray()
    {
        int[,] arrayTable = new int[9, 9];

        for (int str = 0; str < 9; str++)
        {
            for (int clm = 0; clm < 9; clm++)
            {
                arrayTable[str, clm] = (str + 1) * (clm + 1);
            }
        }
        for (int str = 0; str < 9; str++)
        {
            for (int clm = 0; clm < 9; clm++)
            {
                Console.WriteLine(arrayTable[str, clm]);
            }
            Console.WriteLine();
        }
    }
    void ThirdHomeWork()
    {
        int[,] array = new int[5, 5];

        Random random = new Random();

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                array[i, j] = random.Next(0, 100);
            }
        }
        Console.WriteLine("Fill the array with random numbers from 0 to 100");

        int maxNumber = array[0, 0];
        int minNumber = array[0, 0];

        int maxRow = array[0, 0];
        int maxCol = array[0, 0];

        int minCol = array[0, 0];
        int minRow = array[0, 0];

        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (array[i, j] > maxNumber)
                {
                    maxNumber = array[i, j];
                    maxRow = i;
                    maxCol = j;
                }
                if (array[i, j] < minNumber)
                {
                    minNumber = array[i, j];
                    minRow = i;
                    minCol = j;
                }
            }
        }
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"\nThe largest number in the array: {maxNumber}, cordinates: {maxRow}, {maxCol}");
        Console.WriteLine($"\nThe smallest number in the array: {minNumber}, cordinates:{minRow}, {minCol}");
    }
    enum DayOfWeak
    {
        Monday,    // 0
        Tuesday,   // 1
        Wednesday, // 2
        Thursday,  // 3
        Friday,    // 4
        Saturday,  // 5
        Sunday     // 6
    }
     void LastHomework()
     {
      int mounth = 31;

        DayOfWeak today = DayOfWeak.Monday;

        Console.WriteLine($"Today's the day: {today}");
       
        Console.WriteLine("Enter a number to find out what day of the week it will be on a certain day.");
        
        if (int.TryParse(Console.ReadLine(), out int NumberOfDays))
        {
           DayOfWeak resultDay = (DayOfWeak)(NumberOfDays % 7);
           Console.WriteLine($"In {NumberOfDays} days it will be: {resultDay}");
        }

     }   
}



















