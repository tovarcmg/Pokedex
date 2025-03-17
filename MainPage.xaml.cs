using System.Collections.ObjectModel;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
	public ObservableCollection<oneitem> MyItems { get; set; } = new ObservableCollection<oneitem>();

	public MainPage()
	{
		InitializeComponent();
		ListView1.ItemsSource = MyItems;
		BindingContext = this;
		cargarPokemones();
	}

	private void lstAuditorias_ItemSelected(object sender, SelectedItemChangedEventArgs e)
	{
		oneitem seleccionado = e.SelectedItem as oneitem;

		if (seleccionado.myitemname == "Slowbro")
		{
			Versiones page = new Versiones("Slowbro");
			Navigation.PushAsync(page);
		}
		else if (seleccionado.myitemname == "Charizard")
		{
			Versiones page = new Versiones("Charizard");
			Navigation.PushAsync(page);
		}
		else if (seleccionado.myitemname == "Dragonite")
		{
			Versiones page = new Versiones("Dragonite");
			Navigation.PushAsync(page);
		}
	}

	public void cargarPokemones()
	{
		oneitem Slowbro = new oneitem();
		Slowbro.myitemname = "Slowbro";
		MyItems.Add(Slowbro);

		oneitem Charizard = new oneitem();
		Charizard.myitemname = "Charizard";
		MyItems.Add(Charizard);

		oneitem Dragonite = new oneitem();
		Dragonite.myitemname = "Dragonite";
		MyItems.Add(Dragonite);
	}

	public class oneitem
	{
		public string myitemname { get; set; }
	}
}

