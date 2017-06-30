using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDers1
{
	public partial class Ders7Pages : ContentPage
	{
		public Ders7Pages()
		{
			InitializeComponent();

			var list = new List<Personel>
			{
				new Personel{ name="veli",money=100,imageUrl="http://lorempixel.com/400/200/sports/1"},
				new Personel{ name="veli2",money=1000,imageUrl="http://lorempixel.com/400/200/city/1"},
				new Personel{ name="veli3",money=10000,imageUrl="http://lorempixel.com/400/200/cats/1"}
			};

			lstView.ItemsSource = list;
		}
	}
}
