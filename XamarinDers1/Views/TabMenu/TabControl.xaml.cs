using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDers1
{
	public partial class TabControl : TabbedPage
	{
		public TabControl()
		{
			InitializeComponent();

			var page = new Ders2Page();
			page.Title = "ders2";
			page.Icon = "home.png";

			var page3 = new Ders3PAges();
			page3.Title = "ders3";
			page3.Icon = "home.png";


			this.Children.Add(page);
			this.Children.Add(page3);

		}
	}
}
