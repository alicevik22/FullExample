using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_event {
    class Class1 {
        public delegate void Handler0(int t);
        public event Handler0 eventEnd;


        public void Process() {
            int vl = 25;
            ///...
            if (eventEnd != null) eventEnd(vl);
            ///...
        }
    }
}
