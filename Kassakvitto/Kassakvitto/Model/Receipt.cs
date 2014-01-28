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
            get;
            private set; 
        }

        public double MoneyOff
        {
            get;
            private set; 
        }

        public double Subtotal
        {
            get { return _subtotal; }
            private set {
                if(value > 0)
                {
                    _subtotal = value;
                }
                else
                {
                    throw new ApplicationException();
                }
            }
        }

        public double Total
        {
            get;
            private set; 
        }

        public Receipt(double subtotal)
        {
            Calculate(subtotal);
        }

        public void Calculate(double subtotal)
        {
            Subtotal = subtotal;

            if (Subtotal < 500)
            {
                DiscountRate = 0;
            }

            else if (Subtotal < 1000)
            {
                DiscountRate = 0.05;
            }

            else if (Subtotal < 5000)
            {
                DiscountRate = 0.1;
            }

            else if (Subtotal >= 5000)
            {
                DiscountRate = 0.15;
            }

            MoneyOff = Subtotal * DiscountRate;
            Total = Subtotal - MoneyOff;

        }

    }
}