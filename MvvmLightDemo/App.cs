using System;
using Android.App;
using Android.Runtime;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Views;
using MvvmLightDemo.ViewModel;


namespace MvvmLightDemo
{
    public class App : Application
    {
        static ViewModelLocator locator;
        public App(IntPtr h, JniHandleOwnership jho) : base(h, jho) { }

        public static ViewModelLocator Locator
        {
            get
            {
                if (locator == null) {
                    var navigationService = new NavigationService();

                    navigationService.Configure(ViewModelLocator.MainPageKey, typeof(MainActivity));
                    navigationService.Configure(ViewModelLocator.MapPageKey, typeof(MapActivity));

                    SimpleIoc.Default.Register<INavigationService>(() => navigationService);

                    locator = new ViewModelLocator();
                }
                return locator;
            }
        }
    }
}