namespace ConsoleApp1;

public class Math
{


// return smallest numbers based on the count param
    public static List<T> GetSmallestNumbers<T>(T[] numbers, int count)
    {
        Array.Sort(numbers);

        if (numbers == null || numbers.Length == 0) return new List<T>();

        if (numbers.Length < (count - 1)) return numbers.ToList();


        var newList = numbers.ToList();



        var result = newList.Slice(0, count);

        return result;

    }
}
