

namespace FantaLabels.MVVM.Model
{
    public class Label
    {
        public string Name { get; set; }
        public string Owner { get; set; }
        public DateTime EntryDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Purpose { get; set; }

        public Label(string name, string owner, DateTime entryDate, DateTime expirationDate, string purpose)
        {
            Name = name;
            Owner = owner;
            EntryDate = entryDate.Date;
            ExpirationDate = expirationDate.Date;
            Purpose = purpose;
        }
        public override string ToString()
        {
            return $"Label: {Name}, Owner: {Owner}, Entry Date: {EntryDate}, Expiration Date: {ExpirationDate}, Purpose: {Purpose}";
        }

        // default constructor for binding
        public Label() { }
    }
}
