using System;

namespace CustCollectionApp
{
    internal class Customer
    {
        public string lastname;
        public string firstname;
        public int mobile;
        public string tool;

        public string FirstName
        {
            get { return firstname; }
        }

        public string LastName
        {
            get { return lastname; }
        }

        public int Mobile
        {
            get { return mobile; }
        }

        public Customer(string lastName, string firstName, int mobileNumber, string tool)
        {
            this.lastname = lastName;
            this.firstname = firstName;
            this.mobile = mobileNumber;
            this.tool = tool;
        }



        public int CompareTo(Customer another)
        {
            if (this.lastname.CompareTo(another.LastName) < 0)
                return -1;
            else
                    if (this.lastname.CompareTo(another.LastName) == 0)
                return this.firstname.CompareTo(another.FirstName);
            else
                return 1;
        }


        public override string ToString()
        {
            return (firstname + " " + lastname + " " + mobile.ToString() + "\n");
        }
    }
}
