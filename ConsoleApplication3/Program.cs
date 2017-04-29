using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static public List<Vertex> VertexList = new List<Vertex>();
        static public List<Edge> EdgeList = new List<Edge>();
        static void Main(string[] args)
        {
            for (int i = 1; i < 6; i ++)
            {
                VertexList.Add(new Vertex(i));
            }
            EdgeList.Add(new Edge(findVer(1), findVer(2), 5));
            EdgeList.Add(new Edge(findVer(1), findVer(3), 3));
            EdgeList.Add(new Edge(findVer(1), findVer(4), 3));
            EdgeList.Add(new Edge(findVer(1), findVer(5), 4));
            EdgeList.Add(new Edge(findVer(2), findVer(3), 6));
            EdgeList.Add(new Edge(findVer(2), findVer(4), 7));
            EdgeList.Add(new Edge(findVer(3), findVer(5), 2));
            EdgeList.Add(new Edge(findVer(4), findVer(5), 8));
            VertexList = GoNearest(findVer(1));
            foreach (var temp in VertexList)
                Console.WriteLine(temp.Number); 
        }
        static Vertex findVer(int i)
        {
            foreach (var temp in VertexList)
            {
                if (temp.Number == i)
                    return temp;
            }
            return null;
        }
        static List<Vertex> GoNearest (Vertex depo)
        {
            Vertex temp = depo;
            List<Vertex> tempList = new List<Vertex>();
            tempList.Add(depo);
            while (true)
            {
                if (temp.GetMin(EdgeList) != null)
                {
                    temp.flag = true;
                    temp = temp.GetMin(EdgeList);
                    tempList.Add(temp);
                }
                else break;
            }
            return tempList;
        } 
    }
}
