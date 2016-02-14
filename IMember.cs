namespace core3900.Assignment1
{
    public interface IMember
    {
        string FirstName { get; }
        string LastName { get; }
        long Id { get; }

        void Generate();
        string ToString();
        string ToString(bool success);
        int CompareTo(IMember member);
        string HtmlRow();
        string HtmlColumns();
    }
}