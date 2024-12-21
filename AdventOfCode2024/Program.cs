using System.Security.Cryptography.X509Certificates;

class Day1
{
    public static void Main(string[] args)
    {
        List<int> locationIDs1 = new List<int>() { 40, 24, 5, 50, 50, 16, 17, 74, 54, 6, 9, 64, 72, 18, 66, 50, 20, 67, 32, 45, 41, 74, 56, 52, 3, 69, 44, 69, 16, 9, 60, 68, 29, 53, 37, 27, 38, 12, 17, 8, 19, 44, 9, 62, 36, 52, 74, 26, 6, 20 };
        List<int> locationIDs2 = new List<int>() { 74, 68, 50, 48, 41, 41, 5, 56, 71, 45, 36, 9, 51, 32, 11, 31, 51, 58, 13, 54, 48, 22, 65, 32, 8, 74, 5, 20, 46, 35, 33, 59, 34, 70, 65, 11, 60, 49, 31, 62, 51, 29, 29, 59, 19, 66, 75, 61, 10, 72 };

        List<int> newList1 = BubbleSort(locationIDs1);
        List<int> newList2 = BubbleSort(locationIDs2);
        int totalDistance = CheckingDistanceBetweenIDs(newList1, newList2);

        Console.WriteLine($"The total distance is {totalDistance}");
    }
    public static List<int> BubbleSort(List<int> listToSort)
    {
        for (int i = 0; i < listToSort.Count - 1; i++)
        {
            for (int j = 0; j < listToSort.Count - i - 1; j++)
            {
                if (listToSort[j] >  listToSort[j + 1])
                {
                    int temp = listToSort[j];
                    listToSort[j] = listToSort[j + 1];
                    listToSort[j + 1] = temp;
                }
            }
        }
        return listToSort;
    }
    public static int CheckingDistanceBetweenIDs(List<int> list1, List<int> list2)
    {
        if (list1.Count != list2.Count)
        {
            Console.WriteLine("Both lists needs to have the same amount elements in it!");
            Console.WriteLine("Program will now shut down in defiance...");
            Console.ReadKey();
            Environment.Exit(1);
        }
        int distanceResult = 0;
        for (int i = 0; i < list1.Count; i++)
        {
            if (list1[i] > list2[i])
            {
                distanceResult += (list1[i] - list2[i]);
            }
            else
            {
                distanceResult += (list2[i] - list1[i]);
            }
        }
        return distanceResult;
    }
}