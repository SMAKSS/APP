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
using Android.Gms.Maps;
using Android.Gms.Maps.Model;

namespace sportCafe
{
    [Activity(Label = "GoogleMapActivity")]
    public class GoogleMapActivity : Activity,IOnMapReadyCallback
    {
        public void OnMapReady(GoogleMap googleMap)
        {
            MarkerOptions markerOptions = new MarkerOptions();
            markerOptions.SetPosition(new LatLng(35.6892, 51.3890));
            markerOptions.SetTitle("تهران");
            googleMap.AddMarker(markerOptions);

            //optional
            googleMap.UiSettings.ZoomControlsEnabled = true;
            googleMap.UiSettings.CompassEnabled = true;
            googleMap.MoveCamera(CameraUpdateFactory.ZoomIn());
        }

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.GoogleMap);
            MapFragment mapFragment = (MapFragment)FragmentManager.FindFragmentById(Resource.Id.map);
            mapFragment.GetMapAsync(this);
        }
    }
}