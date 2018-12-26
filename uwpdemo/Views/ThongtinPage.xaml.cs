using System;

using uwpdemo.ViewModels;

using Windows.UI.Xaml.Controls;

namespace uwpdemo.Views
{
    public sealed partial class ThongtinPage : Page
    {
        private ThongtinViewModel ViewModel
        {
            get { return ViewModelLocator.Current.ThongtinViewModel; }
        }

        // TODO WTS: Change the grid as appropriate to your app, adjust the column definitions on ThongtinPage.xaml.
        // For more details see the documentation at https://docs.microsoft.com/windows/communitytoolkit/controls/datagrid
        public ThongtinPage()
        {
            InitializeComponent();
        }
    }
}
