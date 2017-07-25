using System;

using Xamarin.Forms;

namespace XamarinDers1
{
	public class ControlPage : MasterDetailPage
	{
		public ControlPage()
		{
			Master = new MastersPage();

			Detail = new DetailsPage();
		}
	}
}

