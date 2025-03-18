using System.Collections.ObjectModel;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
    public List<Pokemon> MyItems { get; set; } = new List<Pokemon>();

    public MainPage()
    {
        InitializeComponent();

        MyItems = new List<Pokemon>();
        ListView1.ItemsSource = MyItems;
        BindingContext = this;
        cargarPokemones();
    }

    private void lstAuditorias_ItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Pokemon seleccionado = e.SelectedItem as Pokemon;

        Versiones page = new Versiones(seleccionado.nombre);
        Navigation.PushAsync(page);
    }

    public void cargarPokemones()
    {
        foreach (var item in ((App)App.Current).pokemonImageCounts)
        {
            MyItems.Add(new Pokemon(item.nombre, item.desc, 0));
        }
    }

    public class Pokemon
    {
        public string nombre { get; set; }
        public string desc { get; set; }
        public int cartas { get; set; }

        // Constructor for easier initialization
        public Pokemon(string _nombre, string _desc, int _cartas)
        {
            nombre = _nombre;
            desc = _desc;
            cartas = _cartas;
        }
    }
}