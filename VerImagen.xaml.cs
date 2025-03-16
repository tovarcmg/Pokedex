namespace MauiApp2;

public partial class VerImagen : ContentPage
{
	public VerImagen(string file)
	{
		InitializeComponent();

		imageZoom.Source = ImageSource.FromFile(file);
	}
}

