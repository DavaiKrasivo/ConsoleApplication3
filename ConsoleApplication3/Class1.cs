using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Vertex
    {
        public int Number;
        public bool flag = false;
        public Edge[] AdjEdge;
        public Vertex(int num)
        {
            Number = num;
        }
        public int GetMin()
        {
            foreach (var temp in AdjEdge)
            {
                
            }
        }
        private Edge[] SortArray(Edge[] Arr)
        {
            int f = 0;
            Edge temp;
            for (int i = 0;i < Arr.Length-1; i ++)
            {
                f = 0;
                for (int j = 1; j < Arr.Length - i; j++)
                {
                    if (Arr[j].length > Arr[j + 1].length)
                    {
                        temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                        f = 1;
                    }
                    if (f == 0) break;
                }
            }
            return Arr;
        }
    }
}
