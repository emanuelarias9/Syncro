using System.Collections.ObjectModel;
using System.Configuration;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace Syncro.ViewModel
{
    public partial class MainViewModel : ObservableObject
    {
        public ObservableCollection<Syncro.Models.Syncro> DañoSyncro
        {
            get; 
            set;
        } = [];

        [ObservableProperty]
        long resistencia;

        [ObservableProperty]
        long nivel;

        [ObservableProperty]
        double dañoBase;

        [ObservableProperty]
        double dañoFinal;

        public MainViewModel()
        {

        }

        public void LoadData()
        {
            DañoSyncro.Clear();
            DañoSyncro.Add(new Models.Syncro { Nivel = 1, DañoBase = 368 });
            for (int i = 2; i < 10; i++)
            {
                var baseAnterior = i - 1;
                var escalado = (736 * baseAnterior);
                DañoSyncro.Add(new Models.Syncro { Nivel = i, DañoBase = 368 + escalado });
            }
        }

        [RelayCommand]
        void CalcularDaño()
        {
            DañoSyncro.Clear();
            var item = new Models.Syncro { Nivel = 1, DañoBase = 368 };
            item.DañoFinal = item.DañoBase - ((item.DañoBase * Resistencia) / 100);
            DañoSyncro.Add(item);
            for (int i = 2; i < 10; i++)
            {
                var baseAnterior = i - 1;
                var escalado = (736 * baseAnterior);
                item = new Models.Syncro { Nivel = i, DañoBase = 368 + escalado };
                item.DañoFinal = item.DañoBase - ((item.DañoBase * Resistencia) / 100);
                DañoSyncro.Add(item);
            }
            Resistencia = 0;
        }
    }
}
