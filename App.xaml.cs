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
            new Pokemon(1,"Bulbasaur","Planta, Veneno", 1,"planta.png"),
            new Pokemon(4,"Charmander","Fuego", 1,"fuego.png"),
            new Pokemon(79,"Slowpoke","Agua, Psíquico", 1,"psi.png"),
            new Pokemon(80,"Slowbro","Agua, Psíquico", 10,"agua.png"),
            new Pokemon(488,"Cresselia","Psíquico", 1,"psi.png"),
            new Pokemon(124,"Jynx","Psíquico", 1,"psi.png"),
            new Pokemon(6,"Charizard","Fuego, Volador", 10,"fuego.png"),
            new Pokemon(149,"Dragonite","Dragón, Volador", 1,"dragon.png"),
            new Pokemon(493,"Arceus","Normal", 1,"normal.png"),
            new Pokemon(133,"Eevee","Normal", 1,"normal.png"),
            new Pokemon(150,"Mewtwo","Psíquico", 6,"psi.png"),
            new Pokemon(25,"Pikachu","Eléctrico", 1,"electrico.png"),
            new Pokemon(94,"Gengar","Fantasma, Veneno", 1,"psi.png"),
            new Pokemon(9,"Blastoise","Agua", 1,"agua.png")
        };

        MainPage = new AppShell();
    }
}
