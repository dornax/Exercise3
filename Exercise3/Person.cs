using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3
{
    internal class Person
    {
        private int _age;

        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0) _age = value;
                else
                    throw new ArgumentException("Age should be greater than 0");
            }
        }

        private string _fName;

        public string FName
        {
            get { return _fName; }
            set
            {
                int fNameLength = value.Length;
                if (fNameLength >= 2 && fNameLength <= 10) _fName = value;
                else
                    throw new ArgumentException(
                        "Firstname should be 2 to 10 characters in length.");
            }
        }

        public string _lName;

        public string LName
        {
            get { return _lName; }
            set
            {

                int lNameLength = value.Length;
                if (lNameLength >= 3 && lNameLength <= 15) _lName = value;
                else
                    throw new ArgumentException(
                        "Lastname should be 3 to 15 characters in length.");
            }
        }

        private double _height;

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        private double _weight;

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
    }
}

