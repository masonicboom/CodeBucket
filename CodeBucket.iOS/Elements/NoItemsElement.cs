using UIKit;

namespace CodeBucket.Elements
{
    public class NoItemsElement : StyledStringElement
    {
        public NoItemsElement()
            : this("No Items")
        {
        }

        public NoItemsElement(string text)
            : base(text)
        {
        }

        public override UITableViewCell GetCell(UITableView tv)
        {
            var c = base.GetCell(tv);
            c.TextLabel.TextAlignment = UITextAlignment.Center;
            return c;
        }

        public override string Summary()
        {
            return string.Empty;
        }
    }
}

