using System;

namespace core3900.Assignment1
{
    /// <summary>
    /// A Member serves as the main contract for reach human resource
    /// </summary>
    public interface IMember : IComparable<IMember>
    {
        string FirstName { get; }
        string LastName { get; }
        long Id { get; }

        void Generate();
        string ToString();
        string ToString(bool success);
        new int CompareTo(IMember member);
        string HtmlRow();
        string HtmlColumns();
    }
}