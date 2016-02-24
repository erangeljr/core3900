using System;

namespace core3900.Assignment1
{
    /// <summary>
    /// Base Class for an Employee
    /// </summary>
    public abstract class Employee: IMember
    {
        protected string department;
        private int yearHired;

        public string FirstName { get; }
        public string LastName { get; }
        public long Id { get; }

        public Employee()
        {
        }

        public void Generate()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"First name: {FirstName} Last name: {LastName}";
        }

        public string ToString(bool success)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(IMember employee)
        {
            // If other is not a valid object reference, this instance is greater.
            if (employee == null) return 1;

            // The temperature comparison depends on the comparison of 
            // the underlying Double values. 
            return LastName.CompareTo(employee.LastName);
        }

        public string HtmlRow()
        {
            throw new NotImplementedException();
        }

        public string HtmlColumns()
        {
            throw new NotImplementedException();
        }
        
    }
}