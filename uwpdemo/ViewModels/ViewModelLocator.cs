using System;

using CommonServiceLocator;

using GalaSoft.MvvmLight.Ioc;

using uwpdemo.Services;
using uwpdemo.Views;

namespace uwpdemo.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        private static ViewModelLocator _current;

        public static ViewModelLocator Current => _current ?? (_current = new ViewModelLocator());

        private ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<MainViewModel, MainPage>();
            Register<SinhvienViewModel, SinhvienPage>();
            Register<HomeViewModel, HomePage>();
            Register<ThongtinViewModel, ThongtinPage>();
        }

        public ThongtinViewModel ThongtinViewModel => ServiceLocator.Current.GetInstance<ThongtinViewModel>();

        public HomeViewModel HomeViewModel => ServiceLocator.Current.GetInstance<HomeViewModel>();

        public SinhvienViewModel SinhvienViewModel => ServiceLocator.Current.GetInstance<SinhvienViewModel>();

        public MainViewModel MainViewModel => ServiceLocator.Current.GetInstance<MainViewModel>();

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
