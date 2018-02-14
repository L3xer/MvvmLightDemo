using MvvmLightDemo.ViewModel;

namespace MvvmLightDemo
{
    public static class App
    {
        private static ViewModelLocator locator;
        public static ViewModelLocator Locator => locator ?? (locator = new ViewModelLocator());
    }
}