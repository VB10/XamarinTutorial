
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDers1
{
	public partial class Ders9Pages : ContentPage
	{
		

		void next_Clicked(object sender, System.EventArgs e)
		{
			img.Source= new UriImageSource{ Uri = new Uri("http://lorempixel.com/400/200/sports/1")};
		}

		void back_Clicked(object sender, System.EventArgs e)
		{
			img.Source= new UriImageSource{ Uri = new Uri("http://lorempixel.com/400/200/food")};
		}

		public Ders9Pages()
		{
			InitializeComponent();



		}
	}
}
