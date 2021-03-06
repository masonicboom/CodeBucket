using UIKit;
using System.Drawing;
using CoreGraphics;

namespace CodeBucket.Cells
{
	public class MultiLineTableCell : UITableViewCell
	{
		public MultiLineTableCell (UITableViewCellStyle style, string reuseIdentifier)
			: base (style, reuseIdentifier)
		{
			BackgroundColor = UIColor.Clear;
		}
		
		public override void LayoutSubviews ()
		{
			base.LayoutSubviews ();
			
			TextLabel.Font = UIFont.SystemFontOfSize(20);
			TextLabel.LineBreakMode = UILineBreakMode.TailTruncation;
			TextLabel.Lines = 1;
			TextLabel.SizeToFit();
			
            TextLabel.Frame = new CGRect(10, 5, Frame.Width, 21);
		}
	}
}