using System;

namespace StudentUnitTestOpgave
{
    public class Student : Person
    {
        private string _name;
        private string _address;
        private int _semester;

        public int Semester
        {
            get => _semester;
            set
            {
                if (value <=1 || value >= 8)
                {
                    throw new ArgumentOutOfRangeException();
                }
                _semester = value;
            }
        }
    }


}

