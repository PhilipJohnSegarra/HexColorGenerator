using Microsoft.Maui.Controls;
namespace HexColorGenerator
{
    public partial class MainPage : ContentPage
    {
        string hexColor, red, green, blue;

        private void ContentPage_Loaded(object sender, EventArgs e)
        {
            HexColor = Color.FromRgb((int)redSlider.Value, (int)greenSlider.Value, (int)blueSlider.Value);
            witchImage.BackgroundColor = HexColor;
            hexColor = HexColor.ToHex();
            hexLabel.Text = hexColor;
        }

        private void copy_Clicked(object sender, EventArgs e)
        {

        }

        Color HexColor = Color.FromRgb(0,0,0);
        

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            HexColor = Color.FromRgb((int)redSlider.Value, (int)greenSlider.Value, (int)blueSlider.Value);
            witchImage.BackgroundColor = HexColor;

            redLabel.Text = "  Red: " + (int)redSlider.Value;
            greenLabel.Text = "  Green: " + (int)(greenSlider.Value);
            blueLabel.Text = "  Blue: " + (int)(blueSlider.Value);

            hexColor = HexColor.ToHex();
            hexLabel.Text = hexColor;
        }

        public MainPage()
        {
            InitializeComponent();
            witchImage.BackgroundColor = HexColor;
        }
    }

}
