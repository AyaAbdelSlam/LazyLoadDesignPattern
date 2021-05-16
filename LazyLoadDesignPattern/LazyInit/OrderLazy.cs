using System;

namespace LazyLoadDesignPattern.LazyInit
{
    public  class OrderLazy
    {
        public OrderLazy()
        {
            // Lazy<T> defaults to thread safe - set isThreadSafe to false if not needed

            _customerInit = new Lazy<Customer>(() => new Customer());
        }

        private Lazy<Customer> _customerInit;

        public Customer Customer
        {
            get
            {
                return _customerInit.Value;
            }
        }

        public string PrintLabel()
        {
            string result = _customerInit.Value.CompanyName; // ok to access backing field
            return result + "\n" + Customer.Address; // ok to access Customer
        }
    }
}