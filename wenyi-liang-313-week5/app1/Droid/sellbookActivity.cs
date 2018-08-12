
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace app1.Droid
{
    [Activity(Label = "SellBookActivity")]
    public class SellBookActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.sell_books);
            Button confirmsellButton = FindViewById<Button>(Resource.Id.confirmsell);
            confirmsellButton.Click += delegate {
                Intent intent = new Intent();
                intent.SetClass(this, typeof(ChooseActivity));
                StartActivity(intent);
            };

            this.Title = "Sell Your Book";
        }
    }
}
