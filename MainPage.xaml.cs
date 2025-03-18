using System.Collections.ObjectModel;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
    public ObservableCollection<Pokemon> MyItems { get; set; } = new ObservableCollection<Pokemon>();

    public MainPage()
    {
        InitializeComponent();

        MyItems = new ObservableCollection<Pokemon>();
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
        string[] pokemones = new string[] { "Slowbro", "Charizard", "Dragonite", "Eevee", "Mewtwo" };

        foreach (var item in pokemones)
        {
            MyItems.Add(new Pokemon { nombre = item });
        }
    }

    public class Pokemon
    {
        public string nombre { get; set; }
    }
}

