using System;

namespace StudentUnitTestOpgave
{
    public class Person
    {
        private string _name;
        private string _address;

        public string Name
        {
            get => _name;
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentException();
                }
                _name = value;
            }
        }

        public string Address
        {
            get => _address;
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                _address = value;
            }
        }

        public GenderType Gender { get; set; }

        public enum GenderType
        {
            Male, Female
        }

    }
}