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
using Android.Support.V7.App;
using Android.Support.V7.Widget;
using sportCafe.Model;
using sportCafe.Common;
using Newtonsoft.Json;
using sportCafe.Adapter;

namespace sportCafe
{
    [Activity(Label = "RssActivity")]
    public class RssActivity : AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        RecyclerView recyclerView;
        RssObject rssObject;

        private const string RSS_link = "http://www.farsnews.com/rss/sports";
        private const string RSS_to_json = "https://api.rss2json.com/v1/api.json?rss_url=";

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.Main_Menu, menu);
            return true;
        }

        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            if (item.ItemId == Resource.Id.menu_refresh)
                LoadData();
            return true;
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.Rss);
            // Create your application here

            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            toolbar.Title = "اخبار ورزشی";
            SetSupportActionBar(toolbar);

            recyclerView = FindViewById<RecyclerView>(Resource.Id.recyclerView);
            LinearLayoutManager linearLayoutManager = new LinearLayoutManager(this, LinearLayoutManager.Vertical, false);
            recyclerView.SetLayoutManager(linearLayoutManager);

            LoadData();
        }

        private void LoadData()
        {
            StringBuilder strbuilder = new StringBuilder(RSS_to_json);
            strbuilder.Append(RSS_link);

            new LoadDataAsync(this).Execute(strbuilder.ToString());
        }

        class LoadDataAsync : AsyncTask<string, string, string>
        {
            RssActivity rssActivity;

            ProgressDialog mDialog;
            
            public LoadDataAsync(RssActivity rssActivity)
            {
                this.rssActivity = rssActivity;
            }

            protected override void OnPreExecute()
            {
                mDialog = new ProgressDialog(rssActivity);
                mDialog.Window.SetType(Android.Views.WindowManagerTypes.SystemAlert);
                mDialog.SetMessage("لطفا صبر کنید");
                mDialog.Show();
            }
            protected override string RunInBackground(params string[] @params)
            {
                string result = new HTTPDataHandler().GetHTTPData(@params[0]);
                return result;
            }

            protected override void OnPostExecute(string result)
            {
                RssObject data = JsonConvert.DeserializeObject<RssObject>(result);
                mDialog.Dismiss();
                FeedAdapter adapter = new FeedAdapter(data, rssActivity);
                rssActivity.recyclerView.SetAdapter(adapter);
                adapter.NotifyDataSetChanged();
            }
        }
    }
}