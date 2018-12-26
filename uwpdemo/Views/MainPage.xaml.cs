using System;

using uwpdemo.ViewModels;

using Windows.UI.Xaml.Controls;

namespace uwpdemo.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return ViewModelLocator.Current.MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
