using System;
using System.Collections.Generic;

namespace Grades
{
    public class GradeBook
    {
        // Field
        private List<float> grades = new List<float>();

        public event NameChangedDelegate NameChanged;

        private string name;

        //Property
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if(!String.IsNullOrEmpty(value))
                {
                    if(name != value)
                    {
                        NameChangedEventArgs args = new NameChangedEventArgs();
                        args.ExistingName = name;
                        args.NewName = value;
                        NameChanged(this, args);
                    }
                    name = value;
                }
            }
        }

        //Constructor 
        public GradeBook()
        {
            name = "Empty";
        }

        //Method
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }

        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats = new GradeStatistics();

            float sum = 0;

            foreach (var grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;

            return stats;
        }
    }
}
