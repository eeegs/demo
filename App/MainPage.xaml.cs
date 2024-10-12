using ModelsEtc;

namespace App
{
    public partial class MainPage : ContentPage
    {
        public MainPage(ViewModel viewModel)
        {
            BindingContext = viewModel;
            InitializeComponent();
        }
    }
}
