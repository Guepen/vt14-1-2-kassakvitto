using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kassakvitto.Model
{
    public class Receipt
    {
        private double _subtotal;

        public double DiscountRate
        {
            public get;
            private set; 
        }

        public double MoneyOff
        {
            public get;
            private set; 
        }

        public double Subtotal
        {
            public get { return _subtotal; }
            private set {
                if(value > 0)
                {
                    _subtotal = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public double Total
        {
            public get;
            private set; 
        }

        public void Calculate(double subtotal)
        {
            Subtotal = subtotal;

        }

        public Receipt(double subtotal)
        { }
    }
}