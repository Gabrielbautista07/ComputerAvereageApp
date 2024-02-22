using System;
using System.Xml.Linq;

namespace ComputerAverageApp {

    class ComputerAverageProgram { 
        static void Main(string[] args)
{
    Console.WriteLine("Enter five(5) grades separated by new Line: ");

    double gr1 = double.Parse(Console.ReadLine());
    double gr2 = double.Parse(Console.ReadLine());
    double gr3 = double.Parse(Console.ReadLine());
    double gr4 = double.Parse(Console.ReadLine());
    double gr5 = double.Parse(Console.ReadLine());

    double average = (gr1 + gr2 + gr3 + gr4 + gr5) / 5;

    double roundedAverage = Math.Round(average);

    Console.WriteLine("The average is " + average + " and the round off to " + roundedAverage);

    Console.WriteLine("Press any key to exit...");
    Console.ReadLine();
}
}

}