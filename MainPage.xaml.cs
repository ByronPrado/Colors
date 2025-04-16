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
		 // Generate random RGB values
		Random random = new Random();
		int red = random.Next(0, 256);
		int green = random.Next(0, 256);
		int blue = random.Next(0, 256);

		// Create a new color from the random RGB values
		Color randomColor = Color.FromRgb(red, green, blue);

		// Set the background color of the page
		this.BackgroundColor = randomColor;

		// Optionally, update the label to display the color values
		Value_label.Text = $"Background Color: RGB({red}, {green}, {blue})";

    }
}

