﻿using System.Collections.ObjectModel;

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
		else if (seleccionado.myitemname == "Eevee")
		{
			Versiones page = new Versiones("Eevee");
			Navigation.PushAsync(page);
		}
		else if (seleccionado.myitemname == "Mewtwo")
		{
			Versiones page = new Versiones("Mewtwo");
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

		oneitem Eevee = new oneitem();
		Eevee.myitemname = "Eevee";
		MyItems.Add(Eevee);

		oneitem Mewtwo = new oneitem();
		Mewtwo.myitemname = "Mewtwo";
		MyItems.Add(Mewtwo);
	}

	public class oneitem
	{
		public string myitemname { get; set; }
	}
}

