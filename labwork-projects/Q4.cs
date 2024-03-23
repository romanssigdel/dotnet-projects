using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace labwork_projects
{
    public class Q4
    {
        // Operator Overloading
        public int x, y;
        public Q4(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public static Q4 operator +(Q4 t1, Q4 t2)
        {
            return new Q4(t1.x+t2.x,t1.y+t2.y);
        }
    }
}
