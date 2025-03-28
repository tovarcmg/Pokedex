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
        foreach (var item in ((App)App.Current).pokemonImageCounts.OrderBy(x => x.id))
        {
            MyItems.Add(new Pokemon(item.id, item.nombre, item.desc, item.cartas, item.ImageUrl));
        }
    }

    public class Pokemon
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string desc { get; set; }
        public int cartas { get; set; }
        public string ImageUrl { get; set; }
        public string no { get; set; }

        // Constructor for easier initialization
        public Pokemon(int _id, string _nombre, string _desc, int _cartas, string _ImageUrl)
        {
            id = _id;
            nombre = _nombre;
            desc = _desc;
            cartas = _cartas;
            ImageUrl = _ImageUrl;
            no = _id.ToString().PadLeft(4, '0');
        }
    }
}