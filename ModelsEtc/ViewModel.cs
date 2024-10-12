using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ModelsEtc
{

    public partial class ViewModel : ObservableObject
    {
        [ObservableProperty]
        ObservableCollection<Seat> seats = [new(), new(), new(), new(), new()];

        public ViewModel()
        {
            Seats[0].Player = new Player { Name = "Alice" };
            Seats[2].Player = new Player { Name = "Bob" };
        }
    }
}
