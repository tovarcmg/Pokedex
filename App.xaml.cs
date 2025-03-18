using System.Collections.ObjectModel;
using static MauiApp2.MainPage;

namespace MauiApp2;

public partial class App : Application
{
    public List<Pokemon> pokemonImageCounts { get; set; } = new List<Pokemon>();

    public App()
    {
        InitializeComponent();

        // Dictionary to map Pokemon names to the number of images

        pokemonImageCounts = new List<Pokemon>
        {
            new Pokemon("Slowbro","Agua, Psíquico", 10),
            new Pokemon("Charizard","Fuego, Volador", 10),
            new Pokemon("Dragonite","Dragón, Volador", 1),
            new Pokemon("Eevee","Normal", 1),
            new Pokemon("Mewtwo","Psíquico", 6),
            new Pokemon("Pikachu","Eléctrico", 1),
            new Pokemon("Gengar","Fantasma, Veneno", 1),
            new Pokemon("Blastoise","Agua", 1)
        };

        MainPage = new AppShell();
    }
}
