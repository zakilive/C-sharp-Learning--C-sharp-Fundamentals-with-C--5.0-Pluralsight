//classes are actually noun and verbs are actually method
using System;


namespace Grades
{
    class Program
    {

        static void Main(string[] args)
        {
            GradeBook book=new GradeBook(4);
            book.AddGrade(91);
            book.AddGrade(80);
            book.AddGrade(75);


            GradeStatistics stats = book.ComputeStatistics();
            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.lowestgrade);
            Console.WriteLine(stats.HighestGrade);

            Console.ReadKey();
        }
    }
}
