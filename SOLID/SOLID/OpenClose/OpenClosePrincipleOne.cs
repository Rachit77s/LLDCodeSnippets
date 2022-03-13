using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.OpenClose
{
    public class Database
    {
        public void AddCustomer()
        {

        }

        public void AddExistingCustomer()
        {

        }

        public void AddAnotherTypeCustomer()
        {

        }
    }

    public class OpenClosePrincipleOneNonCompliant
    {
        public class Customer
        {
            int Type;

            /*
                Currently there are 2 types of Customers New Customers and ExistingCustomers, and if we want to add 
                another type of Cusomter, we will need to add another if else condition which will modify the existing code.
                Hence, violating this principle.
             */
            public void AddCustomer(Database db)
            {
                if (Type == 0)
                {
                    // Add New Customer
                    db.AddCustomer();
                }
                else
                {
                    db.AddExistingCustomer();
                }
            }
        }
    }

    public class OpenClosePrincipleOne
    {
        public class Customer
        {
            public virtual void AddCustomer(Database db)
            {
                // Add New Customer
                db.AddCustomer();
            }
        }

        public class ExistingCustomer : Customer
        {
            public override void AddCustomer(Database db)
            {
                db.AddExistingCustomer();
            }
        }

        public class AnotherTypeCustomer : Customer
        {
            public override void AddCustomer(Database db)
            {
                db.AddAnotherTypeCustomer();
            }
        }
    }

    /*
     * Another example can be Report Generation with type Crystal Report, PDF Report, PowerPointReport etc.
     */
}
