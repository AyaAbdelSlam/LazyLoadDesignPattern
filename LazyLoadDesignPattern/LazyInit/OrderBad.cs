using System;
using System.Collections.Generic;
using System.Text;

namespace LazyLoadDesignPattern.LazyInit
{
    internal class OrderBad
    {
        private Customer _customer;
        public Customer Customer
        {
            get
            {
                if(_customer == null)
                {
                    _customer = new Customer();
                }
                return _customer;
            }
        }

        public string PrintLabel()
        {
            string result = _customer.CompanyName; // probably results in a NullReferenceException
            return result + "\n" + Customer.Address; // ok to access Customer
        }
    }
}
