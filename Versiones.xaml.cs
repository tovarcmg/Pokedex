namespace MauiApp2;

public partial class Versiones : ContentPage
{
    public Versiones(string pokemon)
    {
        InitializeComponent();


        // Dictionary to map Pokemon names to the number of images
        var pokemonImageCounts = new Dictionary<string, int>
        {
            { "Slowbro", 10 },
            { "Charizard", 10 },
            { "Dragonite", 1 },
            { "Eevee", 1 },
            { "Mewtwo", 6 }
        };

        // Check if the pokemon exists in the dictionary and add ImageButton accordingly
        if (pokemonImageCounts.ContainsKey(pokemon))
        {
            int imageCount = pokemonImageCounts[pokemon];

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