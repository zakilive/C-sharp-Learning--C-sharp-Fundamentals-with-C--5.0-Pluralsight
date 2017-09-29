using System;
using System.Collections.Generic;

namespace Grades
{
    class GradeBook
    {
        private List<int> _grades;

        public GradeBook(int maximumGrades)
        {
            _grades = new List<int>(maximumGrades);

        }
        public void AddGrade(int grade)
        {
            if (grade >= 0)
            {
                _grades.Add(grade);
            }
        }

        public GradeStatistics ComputeStatistics()
        {
            
           GradeStatistics stats=new GradeStatistics();
            float sum = 0f;
            stats.HighestGrade = 0;
            foreach(float grade in _grades)
            {

                if (grade > stats.HighestGrade)
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.lowestgrade = Math.Min(grade, stats.lowestgrade);
                sum += grade;
            }
            stats.AverageGrade=sum/_grades.Count;
            
            return stats;
        }
    }
}
