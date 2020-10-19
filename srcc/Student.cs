//using System.Collections.Generic;
using System;
using System.Collections.Generic;

namespace srcc
{
    public class Student
    {
        public List<double> grades=new List<double>();

        public void Addgrade(double grade)
        {
            grades.Add(grade);

        }

        public Statistics GetStatistics()
        {
            var fromStat=new Statistics();
            fromStat.High=double.MinValue;
            fromStat.Low=double.MaxValue;
            foreach(var num in grades)
            {
                fromStat.High=Math.Max(fromStat.High,num);
                fromStat.Low=Math.Min(fromStat.Low,num);
                fromStat.Avarage+=num;

            }
            fromStat.Avarage=fromStat.Avarage/grades.Count;
            return fromStat;

        }
    }
}