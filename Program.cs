namespace _0327_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test std1 = new Test(45, 85);
            Test std2 = new Test(68, 84);

            std1.SetMid(88);
            std1.SetFinal(82);

            Console.WriteLine("1: "+std1.Mid.ToString());
            Console.WriteLine("2: "+std2.Final.ToString());
        }
    }
}
