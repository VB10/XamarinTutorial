using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDers1
{
	public partial class Ders4Pages : ContentPage
	{
		public Ders4Pages()
		{
			InitializeComponent();

		}

		void Handle_Toggled(object sender, Xamarin.Forms.ToggledEventArgs e)
		{
			DisplayAlert("Durum", e.Value + "", "OK");
		}

		void Handle_ValueChanged(object sender, Xamarin.Forms.ValueChangedEventArgs e)
		{
			lbltest.Text = String.Format("Şuanki değer {0:F}", e.NewValue);
		}
	}
}
