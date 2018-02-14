/*
  In App.xaml:
  <Application.Resources>
      <vm:ViewModelLocator xmlns:vm="clr-namespace:MvvmLightDemo"
                           x:Key="Locator" />
  </Application.Resources>
  
  In the View:
  DataContext="{Binding Source={StaticResource Locator}, Path=ViewModelName}"

  You can also use Blend to do all this with the tool's support.
  See http://www.galasoft.ch/mvvm
*/

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using MvvmLightDemo.Core.ViewModel;

namespace MvvmLightDemo.ViewModel
{
    public class ViewModelLocator
    {
        public const string MainPageKey = "FirstPage";
        public const string MapPageKey = "MapPage";

        public ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<MapViewModel>();
        }

        public MainViewModel Main => SimpleIoc.Default.GetInstance<MainViewModel>();
        public MapViewModel Map => SimpleIoc.Default.GetInstance<MapViewModel>();

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}