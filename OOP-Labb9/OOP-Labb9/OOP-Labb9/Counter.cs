using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Labb9
{
    class Counter
    {
        public int Threshold { get; set; }
        public int Total { get; set; } = 0;       
        public event EventHandler ThresholdReached;

        public void Add(int n)
        {
            Total += n;
         
        }

       public virtual void OnThresholdReached(EventArgs e)
        {
            EventHandler handler = ThresholdReached;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
