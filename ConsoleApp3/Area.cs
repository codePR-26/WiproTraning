using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp3
{
    internal class Area
    {
        private int width=0;
        private int Length;
        public Area(int l, int b)
        {
            Length = l;
            width = b;
        }
        public Area(int l)
        {
            Length = l;
        }
        public int CalculateArea()
        {
           if(width==0)
            {
                return Length * Length;
            }
            else
            {
                return Length * width;
            }
        }
    }
}
