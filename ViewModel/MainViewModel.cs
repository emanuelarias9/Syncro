using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Syncro.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        

        [ObservableProperty]
        public ObservableCollection<Syncro.Models.Syncro> dañoSyncro;

        [ObservableProperty]
        string? text;

        [ObservableProperty]
        long nivel;

        [ObservableProperty]
        long dañoBase;

        public MainViewModel()
        {
            
        }

        public void LoadData()
        {
            
        }

        [RelayCommand]
        void CalcularDaño()
        {
            if (string.IsNullOrWhiteSpace(Text)) 
                return;

            //Items.Add(Text);  
            Text =string.Empty;

        }
    }
}
