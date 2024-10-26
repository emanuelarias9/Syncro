using Syncro.ViewModel;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Syncro
{
    public partial class MainPage : ContentPage
    {
        private readonly MainViewModel _MainViewModel;
        public MainPage()
        {
            InitializeComponent();
            _MainViewModel = (MainViewModel)BindingContext;

            var dañosBase = new List<Syncro.Models.Syncro> { 
                new Models.Syncro { Nivel = 1, DañoBase = 368 },
                new Models.Syncro { Nivel = 2, DañoBase = 1104 },
                new Models.Syncro { Nivel = 3, DañoBase = 1840 },
                new Models.Syncro { Nivel = 4, DañoBase = 2576 },
                new Models.Syncro { Nivel = 5, DañoBase = 3312 },
                new Models.Syncro { Nivel = 6, DañoBase = 4048 },
                new Models.Syncro { Nivel = 7, DañoBase = 4784 },
                new Models.Syncro { Nivel = 8, DañoBase = 5520 },
                new Models.Syncro { Nivel = 9, DañoBase = 6256 }
            };
            collectionView.ItemsSource = dañosBase;
        }
    }
}
