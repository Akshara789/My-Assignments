using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpooling
{
    public class member
    {
        long _id;
        string _firstname;
        string _lastname;
        string _email;
        string _contactNumber;
        string _licenceNumber;
        DateTime _licenceStartdate;
        DateTime _licenceExpirydate;

        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Firstname
        {
            get { return _firstname; }
            set { _firstname = value; }
        }
        public string Lastname
        {
            get { return _lastname; }
            set { _lastname = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string ContactNumber
        {
            get { return _contactNumber; }
            set { _contactNumber = value; }
        }

        public string licenceNumber
        {
            get { return _licenceNumber; }
            set
            {
                _licenceNumber = value;
            }
        }
        public DateTime licenceStartdate
        {
            get { return _licenceStartdate; }
            set { _licenceStartdate = value; }
        }
        public DateTime licenceExpirydate
        {
            get { return _licenceExpirydate; }
            set
            {
                _licenceExpirydate = value;
            }
        }

        public member() { }
        public member(long _id, string _firstname, string _lastname, string _email, string _contactNumber, string _licenceNumber, DateTime _licenceStartdate, DateTime _licenceExpirydate)
        {
            Id = _id;
            Firstname = _firstname;
            Lastname = _lastname;
            Email = _email;
            ContactNumber = _contactNumber;
            licenceNumber = _licenceNumber;
            licenceStartdate = _licenceStartdate;
            licenceExpirydate = _licenceExpirydate;
        }
        public void Display()
        {
            Console.WriteLine("Member:{0},{1}", _firstname, _lastname);
            Console.WriteLine($"Member contact details:{_contactNumber},{_email}");
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            member m1 = (member)obj;
            return Email.ToLower() == m1.Email.ToLower() && ContactNumber.ToLower() == m1.ContactNumber.ToLower();
        }
        public override string ToString()
        {
            return string.Format("Member :{0},{1}\n Member contact details:{2}{3}", _firstname, _lastname, Email, ContactNumber);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

    }
}









