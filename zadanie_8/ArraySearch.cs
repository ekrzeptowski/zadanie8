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

}