using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carpoolreq2
{
    internal class MemberCar
    {
        long _id;
        Member _member;
        Car _car;
        string _carRegistrationNumber;
        string _carColor;
        public long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public Member Member
        {
            get { return _member; }
            set { _member = value; }
        }
        public Car Car
        {
            get { return _car; }
            set
            {
                _car = value;
            }
        }
        public string CarRegistrationNumber
        {
            get { return _carRegistrationNumber; }
            set
            {
                _carRegistrationNumber = value;
            }
        }
        public string CarColor
        {
            get { return _carColor; }
            set
            {
                _carColor = value;
            }
        }
        public MemberCar() { }
        public MemberCar(long _id, Member _member, Car _car, string _carRegistration, string _carColour)
        {
            Id = _id;
            Member = _member;
            Car = _car;
            CarRegistrationNumber = _carRegistration;
            CarColor = _carColor;

        }

    }
}
