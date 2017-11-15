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

namespace sportCafe
{
    [Activity(Label = "SignUp")]
    public class SignUpActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here
            SetContentView(Resource.Layout.SignUpActivity);
            string name = Intent.GetStringExtra("نام کاربری" ?? "نام کاربری دریافت نشد");
            string email = Intent.GetStringExtra("ایمیل" ?? "ایمیل دریافت نشد");
            string pass1 = Intent.GetStringExtra("گذر واژه" ?? "گذرواژه دریافت نشد");
            string pass2 = Intent.GetStringExtra("تکرار گذرواژه" ?? "تکرار گذرواژه صحیح نیست");

            var txtName = FindViewById<TextView>(Resource.Id.txtName);
            var txtEmail = FindViewById<TextView>(Resource.Id.txtEmail);
            var txtpass1 = FindViewById<Button>(Resource.Id.txtpass1);
            var txtpass2 = FindViewById<Button>(Resource.Id.txtpass2);
            var btnGoBack = FindViewById<Button>(Resource.Id.btnGoBack);

            txtName.Text = name;
            txtEmail.Text = email;
            txtpass1.Text = pass1;
            txtpass2.Text = pass2;
            btnGoBack.Click += delegate
            {
                this.Finish();
            };
        }
    }
}