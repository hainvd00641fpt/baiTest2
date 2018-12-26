using System;

using uwpdemo.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace uwpdemo.Views
{
    public sealed partial class SinhvienPage : Page
    {
        private SinhvienViewModel ViewModel
        {
            get { return ViewModelLocator.Current.SinhvienViewModel; }
        }

        public SinhvienPage()
        {
            InitializeComponent();
            Loaded += SinhvienPage_Loaded;
        }

        private async void SinhvienPage_Loaded(object sender, RoutedEventArgs e)
        {
            await ViewModel.LoadDataAsync(MasterDetailsViewControl.ViewState);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            // Workaround for issue on MasterDetail Control. Find More info at https://github.com/Microsoft/WindowsTemplateStudio/issues/2738
            ViewModel.Selected = null;
        }
    }
}
