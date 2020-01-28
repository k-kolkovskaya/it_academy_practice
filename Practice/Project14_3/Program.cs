using System;
using System.Collections.Generic;

namespace Project14_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Neighbour K = new Neighbour("Some", 14, 3456788);
            Neighbour A = new Neighbour("Something", 145, 34567883);
            List<Neighbour> floorNeighbours = new List<Neighbour>() { K, A };
        }
    }
}
