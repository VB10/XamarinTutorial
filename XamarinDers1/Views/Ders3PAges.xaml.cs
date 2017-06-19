using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDers1
{
	public partial class Ders3PAges : ContentPage
	{
		public Ders3PAges()
		{
			InitializeComponent();
		}

		void Handle_TextChanged(object sender, Xamarin.Forms.TextChangedEventArgs e)
		{
			writelabel.Text = e.NewTextValue;
		}
	}
}
