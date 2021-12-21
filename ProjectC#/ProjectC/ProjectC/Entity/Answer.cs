using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectC.Entity
{
    class Answer
    {
        private float mark;
        private bool isPassed;
        private string stuID;
        private int qMark;

        public float Mark { get => mark; set => mark = value; }
        public bool IsPassed { get => isPassed; set => isPassed = value; }
        public string StuID { get => stuID; set => stuID = value; }
        public int QMark { get => qMark; set => qMark = value; }
    }
}
