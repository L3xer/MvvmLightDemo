using Android.OS;
using Android.App;
using GalaSoft.MvvmLight.Views;
using GalaSoft.MvvmLight.Helpers;
using MvvmLightDemo.ViewModel;


namespace MvvmLightDemo
{
    [Activity(Label = "MvvmLightDemo", MainLauncher = true)]
    public partial class MainActivity : ActivityBase
    {
        public MainViewModel ViewModel => App.Locator.Main;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            SetupBindings();
        }

        private void SetupBindings()
        {
            this.SetBinding(
                () => ViewModel.TeamName,
                () => TxtTeamName.Text);

            this.SetBinding(
                () => ViewModel.StadiumName,
                () => TxtStadium.Text);

            this.SetBinding(
                () => ViewModel.Capacity,
                () => TxtCapacity.Text);

            this.SetBinding(
                () => ViewModel.NumberOfShuffles,
                () => EditShuffles.Text,
                BindingMode.TwoWay);

            BtnShuffle.SetCommand(
                "Click",
                ViewModel.ButtonClicked);
        }
    }
}

