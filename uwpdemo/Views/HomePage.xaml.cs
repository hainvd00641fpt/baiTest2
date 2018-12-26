using System;

using uwpdemo.ViewModels;

using Windows.UI.Xaml.Controls;

namespace uwpdemo.Views
{
    public sealed partial class HomePage : Page
    {
        private HomeViewModel ViewModel
        {
            get { return ViewModelLocator.Current.HomeViewModel; }
        }

        public HomePage()
        {
            InitializeComponent();
            ViewModel.Initialize(webView);
        }
    }
}
