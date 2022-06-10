namespace Sample1.Models
{
    public class ItemIndex
    {
        public int Index { get; }
        public string Text { get; }

        public ItemIndex(int index, string text)
        {
            Index = index;
            Text = text;
        }
    }
}