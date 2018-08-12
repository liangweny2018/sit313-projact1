
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace app1.Droid
{
    [Activity(Label = "ChooseActivity")]
    public class ChooseActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.choose);

            Button sellBooksButton = FindViewById<Button>(Resource.Id.sellBooksButton);
            sellBooksButton.Click += delegate {
                Intent intent = new Intent();
                intent.SetClass(this, typeof(SellBookActivity));
                StartActivity(intent);
            };

            Button buyBookButton = FindViewById<Button>(Resource.Id.buyBookButton);
            buyBookButton.Click += delegate {
                Intent intent = new Intent();
                intent.SetClass(this, typeof(BuyBookActivity));
                StartActivity(intent);
            };


            this.Title = "Buy or Sell Books";
        }
    }
}
