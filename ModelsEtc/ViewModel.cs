using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace ModelsEtc
{

    public partial class ViewModel : ObservableObject
    {
        // there are a fixed number of seats
        [ObservableProperty]
        ObservableCollection<Seat> seats = [new(), new(), new(), new(), new()];

        public ViewModel()
        {
            // occupy two seats with players
            Seats[0].Player = new Player { Name = "Alice" };
            Seats[2].Player = new Player { Name = "Bob" };
        }
    }
}
