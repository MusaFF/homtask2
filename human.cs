using System;
using System.Collections.Generic;
using System.Text;

namespace task4
{
    class human
    {
        public string Name;
        public string SurName;
        public int Age;

     
        public string GetFullName()
        {
            return $"{Name} {SurName}";
        }
    }
}
