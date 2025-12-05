using PenanoJanBert.View;
using System.Threading.Tasks;

namespace PenanoJanBert
{
    public partial class MainPage : ContentPage
    {
   

        public MainPage()
        {
            InitializeComponent();
        }

        private async void handleNav(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("main");
        }




        private void Button_Clicked(object sender, EventArgs e)
        {

        }
    }
}
