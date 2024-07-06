namespace ConsoleApp1;

public class Loops
{

    public static void Run()
    {
        string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
        foreach (string c in carTypes)
            Console.WriteLine(c);


            // array

            int[] arr = {1,2,3,3,4};

            arr[0] = 0;
            arr[1] = 1;
            // arr[2] = 2;
            
            Console.WriteLine("Arr Length " + arr.Length);

            
        int[] myInts = { 10, 20, 30, 40 };
        foreach (int i in myInts)
            Console.WriteLine(i);
    }
}