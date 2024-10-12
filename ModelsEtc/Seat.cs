using CommunityToolkit.Mvvm.ComponentModel;

namespace ModelsEtc
{
    public partial class Seat : ObservableObject
    {
        [ObservableProperty]
        [NotifyPropertyChangedFor("IsOccupied")]
        Player? player;

        public bool IsOccupied => Player is not null;
    }
}
