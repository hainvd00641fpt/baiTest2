using System;
using System.Collections.ObjectModel;

using GalaSoft.MvvmLight;

using uwpdemo.Models;
using uwpdemo.Services;

namespace uwpdemo.ViewModels
{
    public class ThongtinViewModel : ViewModelBase
    {
        public ObservableCollection<SampleOrder> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
            }
        }
    }
}
