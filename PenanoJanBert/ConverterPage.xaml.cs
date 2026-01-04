using PenanoJanBert.model;
using PenanoJanBert.View;

namespace PenanoJanBert;

public partial class ConverterPage : ContentPage
{
	public ConverterPage(string option)
	{
        InitializeComponent();

        
        converterContainer.Content = new converterView
        {
            BindingContext = new ConverterViewModel(option)
        };

        



    }
}