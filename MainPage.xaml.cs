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
		UpdateBackgroundColor();
	}

    private void Change_background_Clicked(object sender, EventArgs e)
    {
		 // Generate random RGB values
		Random random = new Random();
		int red = random.Next(0, 256);
		int green = random.Next(0, 256);
		int blue = random.Next(0, 256);
		//Update the slider values to the random RGB values
		R.Value = red;
		G.Value = green;
		B.Value = blue;
		UpdateBackgroundColor();
		}

   private void UpdateBackgroundColor(){
		int red = (int)R.Value;
		int green = (int)G.Value;
		int blue = (int)B.Value;
		// Create a new color from the slider values
		Color color = Color.FromRgb(red, green, blue);

        // Set the background color of the page
        BackgroudApp.BackgroundColor = color;

		// Update the label to display the RGB values
		Value_label.Text = $"RGB({red}, {green}, {blue})";
   }
}

