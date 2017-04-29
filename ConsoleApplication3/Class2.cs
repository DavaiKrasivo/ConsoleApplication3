using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Edge
    {
        public Vertex a, b;
        public int length;
        public Edge(Vertex A,Vertex B, int len)
        {
            a = A;
            b = B;
            length = len;
        }

    }
}
