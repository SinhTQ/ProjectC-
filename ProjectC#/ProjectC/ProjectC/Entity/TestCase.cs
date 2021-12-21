using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectC.Entity
{
    class TestCase
    {
        private int question;
        private int paperNo;
        private List<string> input;
        private string output;
        private double mark;

        public TestCase()
        {
            this.input = new List<string>();
            this.Output = "";

        }

        public List<string> Input { get => input; set => input = value; }
        public string Output { get => output; set => output = value; }
        public double Mark { get => mark; set => mark = value; }


        public int Question { get => question; set => question = value; }
        public int PaperNo { get => paperNo; set => paperNo = value; }
    }
}
