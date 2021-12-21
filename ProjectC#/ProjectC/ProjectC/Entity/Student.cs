using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectC.Entity
{
    class Student
    {
        private string stuId;
        private string fullName;
        private string classN;
        private double totalMark;
        private string note;

        public string StuId { get => stuId; set => stuId = value; }
        public string FullName { get => fullName; set => fullName = value; }
        public string ClassN { get => classN; set => classN = value; }
        public double TotalMark { get => totalMark; set => totalMark = value; }
        public string Note { get => note; set => note = value; }

        public Student()
        {
        }

        public Student(string stuId, string fullName, string classN, float totalMark, string note)
        {
            this.stuId = stuId;
            this.fullName = fullName;
            this.classN = classN;
            this.totalMark = totalMark;
            this.note = note;
        }

        public override string ToString()
        {
            return stuId;
        }
    }



}
