namespace PharC
{
    internal class DataFormDisplayOptionsAttribute : Attribute
    {
        public int ColumnSpan { get; set; }
        public string ValidMessage { get; set; }
    }
}