
using Poke.Client.ViewModels;
using Xamarin.Forms;

namespace Poke.Client.Views
{
    public partial class PokeDashPage : ContentPage
    {
        public PokeDashPage()
        {
            InitializeComponent();
            this.BindingContext = new PokeDashViewModel();
        }
    }
}
