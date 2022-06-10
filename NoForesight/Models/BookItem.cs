namespace NoForesight.Models
{
    public class BookItem : Book
    {
        public string PriceRange { get; set; }
        public override string ToString() => $"{Title,-20}{PriceRange}";
    }
}