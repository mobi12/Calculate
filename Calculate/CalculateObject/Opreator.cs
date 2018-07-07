﻿namespace Calculate
{
    public abstract class Opreator
    {
        protected double _num1;
        protected double _num2;

        public double Number1
        {
            set
            {
                _num1 = value;
            }
        }

        public double Number2
        {
            set
            {
                _num2 = value;
            }
        }

        public abstract double GetResult();
    }
}