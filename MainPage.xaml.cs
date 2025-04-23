namespace Colors;
using Microsoft.Maui.Controls;
public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}
	private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
	{
		EstablecerColor();
	}

    private void RandomButton_Clicked(object sender, EventArgs e)
    {
		Random random = new Random();
		int red = random.Next(0, 256);
		int green = random.Next(0, 256);
		int blue = random.Next(0, 256);
		R.Value = red;
		G.Value = green;
		B.Value = blue;
		EstablecerColor();
		}

   private void EstablecerColor(){
		int red = (int)R.Value;
		int green = (int)G.Value;
		int blue = (int)B.Value;
		Color color = Color.FromRgb(red, green, blue);

        BackgroudApp.BackgroundColor = color;
		RandomButton.BackgroundColor = color;
		ColorSquare.Color = color;

		string hex = $"#{red:X2}{green:X2}{blue:X2}";
		Value_label.Text = hex;

   }

   private async void Clipboard_Clicked(object sender, EventArgs e)
	{
		await Clipboard.SetTextAsync(Value_label.Text);
		Label_copied.IsVisible = true;

	}
}

