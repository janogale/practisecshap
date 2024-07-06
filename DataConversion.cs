namespace ConsoleApp1;


public class DataConversion
{
    
    public static short Add(short n1, short n2){

        return (short)(n1 + n2);
    }

    public static int AddBytes(byte b1, byte b2)
    {
        return (b1 + b2);
    }
public static void DeclareImplicitVars()
{
// Implicitly typed local variables.
var myInt = 0;
var myBool = true;
var myString = "Time, marches on...";
// Print out the underlying type.
Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
Console.WriteLine("myString is a: {0}", myString.GetType().Name);
}

}