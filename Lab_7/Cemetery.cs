using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_7
{
    abstract class Cemetery
    {
        private double territory;
        private int count_graves;
        public double Territory
        {
            get
            {
                return territory;
            }
            private set {}
        }
        public int Count_Graves
        {
            get
            {
                return count_graves;
            }
            private set {}
        }
        public Cemetery(double territory, int count_graves)
        {
            this.territory = territory;
            this.count_graves = count_graves;
        }
        public abstract void PrintVal();
    }
}
