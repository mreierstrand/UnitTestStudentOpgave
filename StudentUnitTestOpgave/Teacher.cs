using System;

namespace StudentUnitTestOpgave
{
    public class Teacher : Person
    {
        private string _name;
        private string _address;
        private int _salary;
        private string _address1;

        public int Salary
        {
            get => _salary;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                _salary = value;
            }
        }
    }
}