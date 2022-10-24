namespace zadanie_8;

internal class Program
{
    private static List<int> StringToIntList(string sLiczby)
    {
        List<int> iLiczby = new List<int>();
        string[] arrLiczby = sLiczby.Split(",");
        for (int index = 0; index < arrLiczby.Length; index++)
        {
            string liczba = arrLiczby[index];
            try
            {
                iLiczby.Add(int.Parse(liczba));
            }
            catch (FormatException)
            {
                Console.WriteLine("Uwaga: element znajdujący się na pozycji \"{0}\": {1} nie jest liczbą",
                    index + 1, liczba);
            }
        }

        return iLiczby;
    }
    public static void zadanie_8_2_1()
    {
        Console.WriteLine("Podaj kilka liczb całkowitych oddzielonych przecinkami:");
        string? sLiczby = Console.ReadLine();
        if (sLiczby?.Length != 0 && sLiczby != null)
        {
            List<int> arrLiczby = StringToIntList(sLiczby);
            Console.WriteLine("Największa liczba to: {0}", arrLiczby.Max());
        }
        else
        {
            Console.WriteLine("Nie podano liczb");
        }
    }
    
    public static void zadanie_8_2_2()
    {
        Console.WriteLine("Podaj kilka liczb całkowitych oddzielonych przecinkami:");
        string? sLiczby = Console.ReadLine();
        if (sLiczby?.Length != 0 && sLiczby != null)
        {
            List<int> arrLiczby = StringToIntList(sLiczby);
            Console.WriteLine("Najmniejsza liczba to: {0}", arrLiczby.Min());
        }
        else
        {
            Console.WriteLine("Nie podano liczb");
        }
    }

    public static void Main(string[] args)
    {
        zadanie_8_2_1();
    }
}