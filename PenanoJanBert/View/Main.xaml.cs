using PenanoJanBert.model;

namespace PenanoJanBert.View;

public partial class Main : ContentPage
{
	public Main()
	{
		InitializeComponent();
	}

    private async void TapGestureRecognizer_Tapped(object sender, TappedEventArgs e)
    {
        var option = e.Parameter as string;
        if (option == null)
            return;

        await Navigation.PushAsync(new ConverterPage(option));

    }
}