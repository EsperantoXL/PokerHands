using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;

namespace PokerHands.Droid.Views
{
    [Activity()]
    public class FirstView : MvxActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.FirstView);
        }
    }
}
