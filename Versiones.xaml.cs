namespace MauiApp2;

public partial class Versiones : ContentPage
{
	public Versiones(string pokemon)
	{
		InitializeComponent();

		if (pokemon == "Slowbro")
		{
			for (int i = 1; i < 11; i++)
			{
				// add imageButton 
				ImageButton imageButton = new ImageButton
				{
					Source = "slowbro" + i + ".png",
					HeightRequest = 180,
					WidthRequest = 120,
					Aspect = Aspect.AspectFit,
				};

				imageButton.Clicked += ImageButton_Clicked;

				// add image to FlexLayout
				flexLayout.Children.Add(imageButton);
			}
		}
		else if (pokemon == "Charizard")
		{
			for (int i = 1; i < 5; i++)
			{
				// add imageButton 
				ImageButton imageButton = new ImageButton
				{
					Source = "charizard" + i + ".png",
					HeightRequest = 180,
					WidthRequest = 120,
					Aspect = Aspect.AspectFit,
				};

				imageButton.Clicked += ImageButton_Clicked;

				// add image to FlexLayout
				flexLayout.Children.Add(imageButton);
			}
		}
		else if (pokemon == "Dragonite")
		{
			for (int i = 1; i < 2; i++)
			{
				// add imageButton 
				ImageButton imageButton = new ImageButton
				{
					Source = "dragonite" + i + ".png",
					HeightRequest = 180,
					WidthRequest = 120,
					Aspect = Aspect.AspectFit,
				};

				imageButton.Clicked += ImageButton_Clicked;

				// add image to FlexLayout
				flexLayout.Children.Add(imageButton);
			}
		}
		else if (pokemon == "Eevee")
		{
			for (int i = 1; i < 2; i++)
			{
				// add imageButton 
				ImageButton imageButton = new ImageButton
				{
					Source = "eevee" + i + ".png",
					HeightRequest = 180,
					WidthRequest = 120,
					Aspect = Aspect.AspectFit,
				};

				imageButton.Clicked += ImageButton_Clicked;

				// add image to FlexLayout
				flexLayout.Children.Add(imageButton);
			}
		}
	}

	private void ImageButton_Clicked(object sender, EventArgs e)
	{
		ImageButton ib = sender as ImageButton;

		// get image name
		// DisplayAlert("Image", ib.Source.ToString() , "OK");

		Navigation.PushAsync(new VerImagen(ib.Source.ToString().Replace("File: ", "")));
	}
}

