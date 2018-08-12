
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
    [Activity(Label = "BuyBookActivity")]
    public class BuyBookActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.choose_book);
            // Create your application here
            this.Title = "Choose a book to buy or borrow";


            Button borrowButton = FindViewById<Button>(Resource.Id.ch_borrow);
            borrowButton.Click += delegate {
                Intent intent = new Intent();
               intent.SetClass(this, typeof(ChooseActivity));
                StartActivity(intent);
            };

            Button buyButton = FindViewById<Button>(Resource.Id.ch_buy);
            buyButton.Click += delegate {
                Intent intent = new Intent();
                intent.SetClass(this, typeof(ChooseActivity));
               StartActivity(intent);
            };
        }

    }
}
