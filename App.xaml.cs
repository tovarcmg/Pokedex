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
            new Pokemon("Slowpoke","Agua, Psíquico", 1,"psi.png"),
            new Pokemon("Slowbro","Agua, Psíquico", 10,"psi.png"),
            new Pokemon("Cresselia","Psíquico", 1,"psi.png"),
            new Pokemon("Jynx","Psíquico", 1,"psi.png"),
            new Pokemon("Charizard","Fuego, Volador", 10,"psi.png"),
            new Pokemon("Dragonite","Dragón, Volador", 1,"psi.png"),
            new Pokemon("Arceus","Normal", 1,"psi.png"),
            new Pokemon("Eevee","Normal", 1,"psi.png"),
            new Pokemon("Mewtwo","Psíquico", 6,"psi.png"),
            new Pokemon("Pikachu","Eléctrico", 1,"psi.png"),
            new Pokemon("Gengar","Fantasma, Veneno", 1,"psi.png"),
            new Pokemon("Blastoise","Agua", 1,"psi.png")
        };

        MainPage = new AppShell();
    }
}
