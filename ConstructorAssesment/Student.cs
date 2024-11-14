using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.ConstructorAssesment
{
    public class Student
    {
        private int rollNo;
        private string name;
        private double subject1, subject2, subject3;
        private double totalMarks, percentage;

        public Student(int roll, string nm, double sub1, double sub2, double sub3)
        {
            this.rollNo = roll;
            this.name = nm;
            this.subject1 = sub1;
            this.subject2 = sub2;
            this.subject3 = sub3;
        }
        public void Calculate()
        {
            totalMarks = subject1 + subject2 + subject3;
            percentage = (totalMarks / 300) * 100; 
        }

        public string Print()
        {
            return $"Roll No: {rollNo}\n" +
                   $"Name: {name}\n" +
                   $"Total Marks: {totalMarks}\n" +
                   $"Percentage: {percentage}%";
        }
    }
}
