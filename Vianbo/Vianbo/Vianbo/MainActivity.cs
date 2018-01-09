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
        EditText txtUrl;
        Button btnLoad;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            webView = FindViewById<WebView>(Resource.Id.webView);
            webView.LoadUrl(url: "http://vianbo.com");
            txtUrl = FindViewById<EditText>(Resource.Id.txtUrl);
            btnLoad = FindViewById<Button>(Resource.Id.btnLoad);
            webView.SetWebViewClient(new ExtendWebViewClient());
            

            WebSettings webSettings = webView.Settings;
            webSettings.JavaScriptEnabled = true;

            btnLoad.Click += (s, e) =>
            {
                if (!txtUrl.Text.Contains("http://"))
                {
                    string address = txtUrl.Text;
                    txtUrl.Text = string.Format("http://{0}", address);
                }
                webView.LoadUrl(txtUrl.Text);
            };

        }
    }

    internal class ExtendWebViewClient : WebViewClient
    {
        public override bool ShouldOverrideUrlLoading(WebView view, string url)
        {
            view.LoadUrl(url);
            return true;
        }
    }
}

