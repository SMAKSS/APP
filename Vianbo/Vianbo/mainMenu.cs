using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using Com.Hitomi.Cmlibrary;

namespace Vianbo
{
    [Activity(Label = "mainMenu")]
    public class mainMenu : AppCompatActivity,IOnMenuSelectedListener
    {
        string[] arrayName = { "polimi.vianbo.com" };
        public void OnMenuSelected(int index)
        {
            Toast.MakeText(this, $"You selected {arrayName[index]}", ToastLength.Long).Show();
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.circleMenu);

            var circle_menu = FindViewById<CircleMenu>(Resource.Id.circle_menu);
            circle_menu.SetMainMenu(Color.ParseColor("#f0f0f0"), Resource.Drawable.logo, Resource.Drawable.logo)
                .AddSubMenu(Color.ParseColor("#83b7c7"), Resource.Drawable.education)
                .SetOnMenuSelectedListener(this);
        }
    }
}