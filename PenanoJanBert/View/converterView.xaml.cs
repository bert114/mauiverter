using PenanoJanBert.model;

namespace PenanoJanBert.View;

public partial class converterView : ContentView
{
	public converterView()
	{
		InitializeComponent();



		var vm = new ConverterViewModel();

		var option = vm.Option;

	}
}