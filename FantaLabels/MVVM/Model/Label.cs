



namespace FantaLabels.MVVM.Model
{
    public class Label 
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public string Purpose { get; set; }

        public Label(string name, string owner, DateTime entryDate, DateTime expiryDate, string purpose)
        {
            Name = name;
            Owner = owner;
            EntryDate = entryDate;
            ExpiryDate = expiryDate;
            Purpose = purpose;
        }

        public override string ToString()
        {
            //System.Diagnostics.Debug.WriteLine($"Entry Date: {FormattedEntry}, Expiration Date: {FormattedExpiry}");
            return $"Label: {Name}, Owner: {Owner}, Entry Date: {EntryDate}, Expiration Date: {ExpiryDate}, Purpose: {Purpose}";
        }

        public Label() { }
    }
}
