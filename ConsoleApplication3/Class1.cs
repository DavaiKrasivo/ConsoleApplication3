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
            AdjVer = adj;
        }
        public int GetMin()
        {
            return AdjVer[0];
        }
        private int[] SortArray(int[] Arr)
        {
            int temp = Arr[0];
            for (int i = 1;i < Arr.Length; i ++)
            {
                if (tem)
            }
        }
    }
}
