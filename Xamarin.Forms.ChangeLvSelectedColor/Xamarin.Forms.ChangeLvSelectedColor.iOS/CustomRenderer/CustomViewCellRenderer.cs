using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.ChangeLvSelectedColor.CustomControl.ListView;
using Xamarin.Forms.ChangeLvSelectedColor.iOS.CustomRenderer;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]
namespace Xamarin.Forms.ChangeLvSelectedColor.iOS.CustomRenderer
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var customViewCell = (CustomViewCell)item;

            var cell = base.GetCell(item, reusableCell, tv);

            cell.SelectedBackgroundView = new UIView { BackgroundColor = GetColor(customViewCell.SelectedCellColor) };

            //You can define a new property in the CustomViewCell class, and you can use it here:
            //This code is set the unselected background color of the ViewCell:
            //cell.BackgroundColor = GetColor(customViewCell.UnSelectedCellColor);

            return cell;
        }

        public UIColor GetColor(Helper.ListViewSelectedBackGroundColor color)
        {
            switch (color)
            {
                case Helper.ListViewSelectedBackGroundColor.CianBlue:
                    return Color.FromHex("#40E0D0").ToUIColor();
                default:
                    return Color.Transparent.ToUIColor();
            }
        }
    }
}