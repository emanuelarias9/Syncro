using Syncro.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Syncro
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
            vm.LoadData();
        }
    }
}
