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
        public Vertex(int num)
        {
            Number = num;
        }
        public Vertex GetMin(List<Edge> Adj)
        {
            Edge[] AdjEdge = SortArray(Adj.ToArray());
            foreach (var temp in AdjEdge)
            {
                if (temp.a.Number == this.Number)
                {
                    if (temp.b.flag == false)
                        return temp.b;
                }  
                else if(temp.b.Number == this.Number)
                {
                    if (temp.a.flag == false)
                        return temp.a;
                } 
            }
            return null;
        }
        private Edge[] SortArray(Edge[] Arr)
        {
            int f = 0;
            Edge temp;
            for (int i = 1;i < Arr.Length-1; i ++)
            {
                f = 0;
                for (int j = 0; j < Arr.Length - i; j++)
                {
                    if (Arr[j].length > Arr[j + 1].length)
                    {
                        temp = Arr[j];
                        Arr[j] = Arr[j + 1];
                        Arr[j + 1] = temp;
                        f = 1;
                    }
                }
                if (f == 0) break;
            }
            return Arr;
        }
    }
}
