using System;
using System.Collections.Generic;
using System.Text;

namespace Project14_3
{
    class Neighbour
    {
        public string FullName { get; set; }
        public int FlatNumber { get; set; }
        public int PhoneNumber { get; set; }

        public Neighbour (string name, int flat, int phone)
        {
            FullName = name;
            FlatNumber = flat;
            PhoneNumber = phone;
        }
    }
}
