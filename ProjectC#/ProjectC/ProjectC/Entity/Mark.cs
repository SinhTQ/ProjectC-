using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectC.Entity
{
    class Mark
    {
        private float MarkQ;

        public float MarkQ1 { get => MarkQ; set => MarkQ = value; }

        public Mark() { }

        public Mark(float markQ)
        {
            MarkQ = markQ;
        }
        public string toString()
        {
            return MarkQ + " ";
        }
    }
}
