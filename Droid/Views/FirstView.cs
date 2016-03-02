using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace PokerHands.Droid.Views
{
    [Activity(Label = "PokerHands", MainLauncher = true, Icon = "@mipmap/icon")]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
