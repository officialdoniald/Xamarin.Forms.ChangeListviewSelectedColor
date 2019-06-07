using System.ComponentModel;
using Android.Content;
using Android.Views;
using Xamarin.Forms;
using Xamarin.Forms.ChangeLvSelectedColor.CustomControl.ListView;
using Xamarin.Forms.ChangeLvSelectedColor.Droid.CustomRenderers;
using Xamarin.Forms.ChangeLvSelectedColor.Helper;
using Xamarin.Forms.Platform.Android;
using static Xamarin.Forms.ChangeLvSelectedColor.Droid.MainActivity;

[assembly: ExportRenderer(typeof(CustomViewCell), typeof(CustomViewCellRenderer))]
namespace Xamarin.Forms.ChangeLvSelectedColor.Droid.CustomRenderers
{
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        protected override global::Android.Views.View GetCellCore(Cell item, global::Android.Views.View convertView, ViewGroup parent, Context context)
        {
            var _cellCore = base.GetCellCore(item, convertView, parent, context);

            return _cellCore;
        }

        protected override void OnCellPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            base.OnCellPropertyChanged(sender, args);

            var extendedViewCell = (CustomViewCell)sender;

            if (extendedViewCell.SelectedCellColor == ListViewSelectedBackGroundColor.CianBlue)
            {
                AndroidEvents.OnAndroidThemeChangeNeeded_Event(null, Xamarin.Forms.ChangeLvSelectedColor.Droid.Resource.Style.MainCianBlueTheme);
            }
            else if (extendedViewCell.SelectedCellColor == ListViewSelectedBackGroundColor.Normal)
            {
                AndroidEvents.OnAndroidThemeChangeNeeded_Event(null, Xamarin.Forms.ChangeLvSelectedColor.Droid.Resource.Style.MainTheme);
            }
            else if (extendedViewCell.SelectedCellColor == ListViewSelectedBackGroundColor.Transparent)
            {
                AndroidEvents.OnAndroidThemeChangeNeeded_Event(null, Xamarin.Forms.ChangeLvSelectedColor.Droid.Resource.Style.MainTransparentTheme);
            }
        }
    }
}