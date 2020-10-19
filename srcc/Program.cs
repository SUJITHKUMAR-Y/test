using System;

namespace srcc
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            var Sg=new Student();
            Sg.Addgrade(90.8);
            Sg.Addgrade(75.6);
            Sg.Addgrade(91.5);
            Sg.Addgrade(68.9);
            Sg.Addgrade(85.5);

            var result=Sg.GetStatistics();

            Console.WriteLine($"avarage grade={result.Avarage}");
            Console.WriteLine($"High grade={result.High}");
            Console.WriteLine($"Low grade={result.Low}");
            

        }
    }
}
