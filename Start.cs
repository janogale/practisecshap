using TextUtilLibrary;


namespace ConsoleApp1;

class Startup()
{

    public static void Main()
    {

        System.Console.WriteLine("Bismilah");

        StringProcessor.FunWithStringBuilder();

        // data conversion

        long n1 = 1234567890123456789;
        int s1 = (short)n1;

        int result = DataConversion.Add(2, 5);



        //DataConversion.DeclareImplicitVars();


        Loops.Run();


    }
}
