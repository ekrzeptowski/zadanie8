namespace zadanie_8;

internal class ArraySearch
{
    public static void MinMax(List<int> intList,string type)
    {
            switch (type)
            {
                case "max":
                    Console.WriteLine("Największa liczba to: {0}", intList.Max());
                    break;
                case "min":
                    Console.WriteLine("Najmniejsza liczba to: {0}", intList.Min());
                    break;
            }
            
    }
    
    public static void MinMaxAndOccurence(List<int> intList,string type)
    {
        switch (type)
        {
            case "max":
                int max = intList.Max();
                int maxCount = intList.Count(current => current == max);
                Console.WriteLine("Największa liczba to: {0}. Liczba wystąpień: {1}", max, maxCount);
                break;
            case "min":
                int min = intList.Min();
                int minCount = intList.Count(current => current == min);
                Console.WriteLine("Najmniejsza liczba to: {0}. Liczba wystąpień: {1}", min, minCount);
                break;
        }
            
    }
}