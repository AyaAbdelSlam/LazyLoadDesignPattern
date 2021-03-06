using System.Diagnostics;

namespace LazyLoadDesignPattern
{
    public  class Customer
    {
        public Customer()
        {
            Debug.Print("Initializing Customer");
            CompanyName = "Company Name";
            Address = "Default Address";
        }
        public string CompanyName { get; set; }
        public string Address { get; set; }
    }
}