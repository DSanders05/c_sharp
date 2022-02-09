using System;

namespace classDemo
{
    public class Dinosaur : Animal
    {
        public Dinosaur(string sp, string d, int lifespan, double wgt) : base(sp,d,ls,wgt)
        {
            public string period;

            public Dinosaur(string sp, string d,int ls, double w,string hp) :base(sp,d,ls,w)
            {
                period = hp;
            }
        }
    }
}