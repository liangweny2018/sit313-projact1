using Android.App;
using Android.Widget;
using Android.OS;
using Android.Content;

namespace app1.Droid
{
    [Activity(Label = "app1", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            Button loginButton = FindViewById<Button>(Resource.Id.LoginButton);

            loginButton.Click += delegate {
                Intent intent = new Intent();
                intent.SetClass(this, typeof(ChooseActivity));
                StartActivity(intent);
            };

            // and attach an event to it
            Button createAccountButton = FindViewById<Button>(Resource.Id.CreateAccountButton);

            createAccountButton.Click += delegate { 
                Intent intent = new Intent();
                intent.SetClass(this, typeof(RegisterActivity));
                StartActivity(intent);
            };
            this.Title = "Book Store";

        }
    }
}

