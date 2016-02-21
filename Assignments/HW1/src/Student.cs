using System;

namespace core3900.Assignment1
{
    /// <summary>
    /// Student
    /// </summary>
    public class Student : IMember
    {
        private float GPA;
        protected string major;

        public string FirstName { get; }
        public string LastName { get; }
        public long Id { get; }

        //Default Constructor
        public Student()
        {
        }

        /// <summary>
        /// Generates Students
        /// </summary>
        public void Generate()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Helper method to return Student properties as a string
        /// </summary>
        /// <returns>This Student as String</returns>
        public override string ToString()
        {
            return $"First name: {FirstName} Lastname: {LastName}";
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