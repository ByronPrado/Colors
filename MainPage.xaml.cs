namespace Colors;
using Microsoft.Maui.Controls;
public partial class MainPage : ContentPage
{
	//int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}
	private void Slide_change(object sender, ValueChangedEventArgs e)
	{
		Value_label.Text= $"Valor: {e.NewValue:0}";
	}

    private void Change_background_Clicked(object sender, EventArgs e)
    {
		
    }
}

