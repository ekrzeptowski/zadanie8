namespace zadanie_8;

internal class ArrayElementsProcessing
{
    public static void PowValues(List<double> doubleList, double power)
    {
        List<double> powedList = new List<double>();
        doubleList.ForEach(current => powedList.Add(Math.Pow(current, power)));
        Console.WriteLine(String.Join(", ", powedList));
    }
    
    public static void AddValues(List<double> doubleList, double value)
    {
        List<double> addedList = new List<double>();
        doubleList.ForEach(current => addedList.Add(current + value));
        Console.WriteLine(String.Join(", ", addedList));
    }
}