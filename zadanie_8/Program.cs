using static zadanie_8.Tools;
using static zadanie_8.ArraySearch;

namespace zadanie_8;

internal class Program
{
    public static void ArraySearchMenu()
    {
        Console.WriteLine("1. Znajdź największą liczbę\n" +
                          "2. Znajdź najmniejszą liczbę\n" +
                          "3. Znajdź największą liczbę i wyświetl ile razy wystąpiła\n" +
                          "4. Znajdź najmniejszą liczbę i wyświetl ile razy wystąpiła\n" +
                          "5. Znajdź drugą co do wielkości największą liczbę\n" +
                          "6. Znajdź drugą co do wielkości najmniejszą liczbę\n" +
                          "7. Znajdź ile razy wystąpiła druga co do wielkości największa liczba\n" +
                          "8. Znajdź ile razy wystąpiła druga co do wielkości najmniejsza liczba");
        int task;
        if (int.TryParse(Console.ReadLine(), out task))
        {
            Console.WriteLine("Podaj kilka liczb całkowitych oddzielonych przecinkami:");
            string? sLiczby = Console.ReadLine();
            if (sLiczby?.Length != 0 && sLiczby != null)
            {
                List<int> arrLiczby = StringToIntList(sLiczby);
                switch (task)
                {
                    case 1:
                        MinMax(arrLiczby, "max");
                        break;
                    case 2:
                        MinMax(arrLiczby, "min");
                        break;
                    case 3:
                        MinMaxAndOccurence(arrLiczby, "max");
                        break;
                    case 4:
                        MinMaxAndOccurence(arrLiczby, "min");
                        break;
                    case 5:
                        SecondValue(arrLiczby, "max");
                        break;
                    case 6:
                        SecondValue(arrLiczby, "min");
                        break;
                    default:
                        Console.WriteLine("Wybrano nieprawidłowy element");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Nie podano liczb");
            }
        }
        else
        {
            Console.WriteLine("Wybrano nieprawidłowy element");
        }
        
    }

    public static void ArrayElementsProcessingMenu()
    {
        
    }
    public static void ArrayElementsProcessingWithGivenValuesMenu()
    {
        
    }
    public static void ArrayElementsProcessingWithGivenIndexesMenu()
    {
        
    }

    public static void MiscellaneousMenu()
    {
        
    }
    public static void TaskTypeRoute(int typeSelection)
    {
        switch (typeSelection)
        {
            case 2:
                ArraySearchMenu();
                break;
            case 3:
                ArrayElementsProcessingMenu();
                break;
            case 4:
                ArrayElementsProcessingWithGivenValuesMenu();
                break;
            case 5:
                ArrayElementsProcessingWithGivenIndexesMenu();
                break;
            case 6:
                MiscellaneousMenu();
                break;
            default:
                Console.WriteLine("Wybrano nieprawidłowy element");
                break;
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Zadanie 8");
        Console.WriteLine("Wybierz typ zadania z listy.");
        Console.WriteLine("2. Wyszukiwanie w tablicy\n" +
                          "3. Przetwarzanie elementów tablicy\n" +
                          "4. Przetwarzanie elementów tablicy o zadanych wartościach\n" +
                          "5. Przetwarzanie elementów tablicy o zadanych indeksach\n" +
                          "6. Różne");
        int type;
        if (int.TryParse(Console.ReadLine(), out type))
        {
            TaskTypeRoute(type);
        }
        else
        {
            Console.WriteLine("Wybrano nieprawidłowy element");
        }
    }
}