using Xamarin.Forms;

namespace XamarinDers1
{
	public partial class XamarinDers1Page : ContentPage
	{
		public XamarinDers1Page()
		{
			InitializeComponent();

			Label label1 = new Label();

			label1.Text = "vlei";
			label1.HorizontalOptions = LayoutOptions.Center;
			Content = label1;
		}
	}
}
