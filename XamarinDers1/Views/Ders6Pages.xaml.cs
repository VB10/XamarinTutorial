using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDers1
{
	public partial class Ders6Pages : ContentPage
	{
		public Ders6Pages()
		{
			InitializeComponent();

			var list = new List<Personel>
			{
				new Personel{name="veli",money=100,imageUrl="http://lorempixel.com/400/200/sports/1"
				},
				new Personel{name="veli2",money=1002,imageUrl="http://lorempixel.com/400/200/sports"
				},
			};

			lstView.ItemsSource = list;


		}
	}
}
