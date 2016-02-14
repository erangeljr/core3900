using System;

namespace core3900.Assignment1
{
    public abstract class Employee: IMember
    {
        protected string department;
        private int yearHired;

        public string FirstName { get; }
        public string LastName { get; }
        public long Id { get; }

        public void Generate()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            throw new NotImplementedException();
        }

        public string ToString(bool success)
        {
            throw new NotImplementedException();
        }

        public int CompareTo(IMember member)
        {
            throw new NotImplementedException();
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