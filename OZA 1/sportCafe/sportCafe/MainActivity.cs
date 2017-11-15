using Android.App;
using Android.Widget;
using Android.OS;
using Android.Support.V7.App;
using Android.Graphics;
using Com.Hitomi.Cmlibrary;
using System;

namespace sportCafe
{
    [Activity(Label = "sportCafe", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : AppCompatActivity, IOnMenuSelectedListener
    {
        string[] arrayName = { "group", "hall", "setting", "shop" };
        public void OnMenuSelected(int index)
        {
            Toast.MakeText(this, $"you selected {arrayName[index]}", ToastLength.Long).Show();
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView (Resource.Layout.Main);

            var circle_menu = FindViewById<CircleMenu>(Resource.Id.circle_menu);
            circle_menu.SetMainMenu(Color.ParseColor("#CDCDCD"), Resource.Drawable.sc_open, Resource.Drawable.sc_close)
                .AddSubMenu(Color.ParseColor("#258CFF"), Resource.Drawable.sc_group)
                .AddSubMenu(Color.ParseColor("#258CFF"), Resource.Drawable.sc_hall)
                .AddSubMenu(Color.ParseColor("#258CFF"), Resource.Drawable.sc_setting)
                .AddSubMenu(Color.ParseColor("#258CFF"), Resource.Drawable.sc_shopping)
                .SetOnMenuSelectedListener(this);
        }
    }
}

