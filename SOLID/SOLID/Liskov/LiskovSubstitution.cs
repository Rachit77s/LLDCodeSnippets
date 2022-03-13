using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Liskov
{
    public class LiskovSubstitutionNonCompliant
    {
        // Program for discounts on Enqueries
        public class Customer
        {
            public virtual int Discount(int totalSales)
            {
                return totalSales;
            }

            public virtual void AddCustomer(Customer cust)
            {
                // DB logic to add Customers
            }
        }

        // Enqueries are not actual customer, they are leads, therefore, we don't want to save them to DB for now.
        // So we create Enquiry inheriting Customer, we provide some discount to the enqueries to convert them into actual customers.
        // We override the AddCustomer method with an exception so that no one can add an Enquiry to the DB.
        public class Enquiry : Customer
        {
            public override int Discount(int totalSales)
            {
                return totalSales - 50;
            }

            public override void AddCustomer(Customer cust)
            {
                throw new Exception("Not Allowed. Can't add Customers through Enquiry class.");
            }
        }

        public class GoldCustomer : Customer
        {
            public override int Discount(int totalSales)
            {
                return totalSales - 100;
            }
        }

        public class SilverCustomer : Customer
        {
            public override int Discount(int totalSales)
            {
                return totalSales - 75;
            }
        }

        public class Main
        {
            public void ParseCustomers()
            {
                List<Customer> customers = new List<Customer> 
                                           {
                                                new GoldCustomer(),
                                                new SilverCustomer(),
                                                new Enquiry()   // This is valid but will cause exception in the next line.
                                           };

                foreach (var cust in customers)
                {
                    // Enquiry.AddCustomer will throw an exception.
                    cust.AddCustomer(new Customer());
                }

                /*
                    When AddCustomer method of the Enquiry class is invoked, it leads to exception.
                    Enquiry class only deals with Enqueries, it looks like a "Customer Class" but it is not a CUSTOMER.
                    Hence, the parent class Customer cannot be replaced by child class Enquiry. therefore ,violating Liskov.
                 */
            }
        }
    }

    public class LiskovSubstitution
    {
        /*
            By LiskovSubstitutionNonCompliant class we learn that, Customer class is not the actual parent for the Enquiry Class.
            Rather Enquiry class should be a different entity altogether.
         */
        public interface IDiscount
        {
            int Discount(int totalSales);
        }

        public interface IDatabase
        {
            void AddCustomer(Customer cust);
        }

        public class Customer : IDiscount, IDatabase
        {
            public virtual int Discount(int totalSales)
            {
                return totalSales;
            }

            public virtual void AddCustomer(Customer cust)
            {
                // DB logic to add Customers
            }
        }

        public class Enquiry : IDiscount
        {
            public int Discount(int totalSales)
            {
                return totalSales - 50;
            }
        }

        public class GoldCustomer : Customer
        {
            public override int Discount(int totalSales)
            {
                return totalSales - 100;
            }
        }

        public class SilverCustomer : Customer
        {
            public override int Discount(int totalSales)
            {
                return totalSales - 75;
            }
        }

        public class Main
        {
            public void ParseCustomers()
            {
                List<Customer> customers = new List<Customer>
                                           {
                                                new GoldCustomer(),
                                                new SilverCustomer(),
                                                //new Enquiry()   // This will now give CTE.
                                           };

                foreach (var cust in customers)
                {
                    // Enquiry.AddCustomer will throw an exception but as we have rectified the problem this time, hence, it will not throw an exception.
                    cust.AddCustomer(new Customer());
                }
            }
        }
    }
}
