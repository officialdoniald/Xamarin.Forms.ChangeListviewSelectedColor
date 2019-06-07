using Xamarin.Forms.ChangeLvSelectedColor.Helper;

namespace Xamarin.Forms.ChangeLvSelectedColor.CustomControl.ListView
{
    public class CustomViewCell : ViewCell
    {
        public static readonly BindableProperty SelectedCellColorProperty =
           BindableProperty.Create("SelectedCellColor", typeof(ListViewSelectedBackGroundColor), typeof(CustomViewCell), ListViewSelectedBackGroundColor.Normal);

        public ListViewSelectedBackGroundColor SelectedCellColor
        {
            get { return (ListViewSelectedBackGroundColor)GetValue(SelectedCellColorProperty); }
            set { SetValue(SelectedCellColorProperty, value); }
        }
    }
}