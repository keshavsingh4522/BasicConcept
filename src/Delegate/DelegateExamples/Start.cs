namespace DelegateExamples;

public static class Start
{
    public delegate void MyDelegate(string msg);

    public static void Method1(string Message)
    {
        Console.WriteLine("Method1 > " + Message);
    }

    public static void Method2(string Message)
    {
        Console.WriteLine("Method2 > " + Message.ToUpper());
    }
}
//public class M
//{
//    public unsafe int* p;

//    public unsafe int* MP()
//    {
//        int m = 8;
//        return &m;
//    }
//}
//public unsafe class MP2
//{
//    public int* p;

//    public int* MP()
//    {
//        int m = 8;
//        return &m;
//    }
//}
