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
        public int CountAdjVer;
        public int[] AdjVer;
        public Vertex(int num,int[] adj)
        {
            Number = num;
            AdjVer = SortArray(adj);
        }
        public int GetMin()
        {
            return AdjVer[0];
        }
        private int[] SortArray(int[] Arr)
        {
            int f = 0;
            int temp;
            for (int i = 0;i < Arr.Length-1; i ++)
            {
                f = 0;
                for (int j = 1; j < Arr.Length - i; j++)
                {
                    if (Arr[j] > Arr[j + 1])
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
