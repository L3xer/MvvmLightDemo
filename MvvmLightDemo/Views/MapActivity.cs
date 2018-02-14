using Android.OS;
using Android.App;


namespace MvvmLightDemo
{
    [Activity(Label = "MapActivity")]
    public class MapActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.Map);
        }
    }
}