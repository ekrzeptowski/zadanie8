namespace zadanie_8;

internal class ArrayElementsProcessing
{
    public static void PowValues(List<double> doubleList, double power)
    {
        List<double> powedList = new List<double>();
        doubleList.ForEach(current => powedList.Add(Math.Pow(current, power)));
        Console.WriteLine(String.Join(", ", powedList));
    }
}