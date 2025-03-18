namespace MauiApp2;

public partial class Versiones : ContentPage
{
    public Versiones(string pokemon)
    {
        InitializeComponent();

        // Check if the pokemon exists in the dictionary and add ImageButton accordingly
        if (((App)App.Current).pokemonImageCounts.Any(x => x.nombre == pokemon))
        {
            int imageCount = ((App)App.Current).pokemonImageCounts.Where(x => x.nombre == pokemon).FirstOrDefault().cartas;

            for (int i = 1; i <= imageCount; i++)
            {
                // Create ImageButton for each image
                ImageButton imageButton = new ImageButton
                {
                    Source = $"{pokemon.ToLower()}{i}.png",  // Use pokemon name and the number for the image
                    HeightRequest = 180,
                    WidthRequest = 120,
                    Aspect = Aspect.AspectFit,
                };

                // Attach the click event
                imageButton.Clicked += ImageButton_Clicked;

                // Add the ImageButton to the layout
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