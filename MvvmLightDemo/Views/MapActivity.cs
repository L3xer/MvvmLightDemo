using Android.OS;
using Android.App;
using Android.Gms.Maps;
using Android.Gms.Maps.Model;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;


namespace MvvmLightDemo
{
    [Activity(Label = "MapActivity")]
    public partial class MapActivity : ActivityBase, IOnMapReadyCallback
    {
        private double latitude;
        private double longitude;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Map);

            var navigationService = (NavigationService)SimpleIoc.Default.GetInstance<INavigationService>();
            (latitude, longitude) = navigationService.GetAndRemoveParameter<(double, double)>(Intent);

            SetupMapView();
        }

        private void SetupMapView()
        {
            var mapFragment = FragmentManager.FindFragmentById(Resource.Id.mapView) as MapFragment;
            mapFragment.GetMapAsync(this);
        }

        public void OnMapReady(GoogleMap googleMap)
        {
            var marker = new MarkerOptions();
            marker.SetPosition(new LatLng(latitude, longitude));
            googleMap.AddMarker(marker);
        }
    }
}