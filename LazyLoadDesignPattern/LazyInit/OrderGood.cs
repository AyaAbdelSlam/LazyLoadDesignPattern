using System;
using System.Collections.Generic;
using System.Text;

namespace LazyLoadDesignPattern.LazyInit
{
    internal class OrderGood
    {
        private Customer _customer;
        public Customer Customer
        {
            get
            {
                if (_customer == null)
                {
                    _customer = new Customer();
                }
                return _customer;
            }
        }

        public string PrintLabel()
        {
            string result = Customer.CompanyName; // Wont throw NullReferenceException
            return result + "\n" + Customer.Address; // ok to access Customer
        }
    }
}
