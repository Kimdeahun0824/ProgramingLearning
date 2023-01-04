namespace WhatIsParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Description description = new Description();
            int a = 10;
            int b = 20;
            description.ValueTypeParam(a, b);
            description.RefTypeParam(ref a, ref b);
            Console.WriteLine("{0} {1}", a, b);

            description.FlexibleTypeParam(1,2);
        }
    } 
}