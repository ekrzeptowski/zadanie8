namespace zadanie_8;

internal class Tools
{
    public static List<int> StringToIntList(string sLiczby)
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
}