using Android.App;
using Android.Widget;
using Android.OS;
using Android.Webkit;

namespace Vianbo
{
    [Activity(Label = "Vianbo", MainLauncher = true)]
    public class MainActivity : Activity
    {
        WebView webView;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            webView = FindViewById<WebView>(Resource.Id.webView);
            webView.SetWebViewClient(new WebViewClient());
            webView.Settings.JavaScriptEnabled = true;
            webView.LoadUrl("http://polimi.vianbo.com");
        }

        public override void OnBackPressed()
        {
            webView.GoBack();
        }
    }
}

