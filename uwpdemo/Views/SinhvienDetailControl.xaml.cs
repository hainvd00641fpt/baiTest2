using System;

using uwpdemo.Models;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace uwpdemo.Views
{
    public sealed partial class SinhvienDetailControl : UserControl
    {
        public SampleOrder MasterMenuItem
        {
            get { return GetValue(MasterMenuItemProperty) as SampleOrder; }
            set { SetValue(MasterMenuItemProperty, value); }
        }

        public static readonly DependencyProperty MasterMenuItemProperty = DependencyProperty.Register("MasterMenuItem", typeof(SampleOrder), typeof(SinhvienDetailControl), new PropertyMetadata(null, OnMasterMenuItemPropertyChanged));

        public SinhvienDetailControl()
        {
            InitializeComponent();
        }

        private static void OnMasterMenuItemPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var control = d as SinhvienDetailControl;
            control.ForegroundElement.ChangeView(0, 0, 1);
        }
    }
}
