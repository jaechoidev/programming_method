/*
 * Person, Customer, PreferredCustomer Class
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetailStoreApp
{
    public class Person
    {
        // A class named Person with properties for holding a person’s name, address, and telephone number.
        private string name, address, phone;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }
            set
            {
                phone = value;
            }
        }

    }

    public class Customer: Person
    {
        /* A class named Customer, which is derived from the Person class, 
         * which have a property for a customer number and a Boolean property 
         * indicating whether the customer wishes to be on a mailing list. 
        */
        private string id;
        private bool mailing;

        public string ID
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public bool Mailing
        {
            get
            {
                return mailing;
            }
            set
            {
                mailing = value;
            }
        }
    }

    public class PreferredCustomer: Customer
    {
        /* A class named PreferredCustomer, which is derived from the Customer class. 
         * This class has properties for the mount of the customer’s purchases and the customer’s discount level. 
         */
        private double amountOfPurchase;
        private int level;
        
        public PreferredCustomer(string lid = null, string lname = null, string laddress = null, string lphone = null, bool lmailing = false, double lamountOfPurchase = 0.0f, int llevel = 0)
        {
            ID = lid;
            Name = lname;
            Address = laddress;
            Phone = lphone;
            Mailing = lmailing;
            amountOfPurchase = lamountOfPurchase;
            level = llevel;
        }
        public double AmountOfPurchase
        {
            get
            {
                return amountOfPurchase;
            }
            set
            {
                amountOfPurchase = value;
            }
        }
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                level = value;
            }
        }
    }
}
