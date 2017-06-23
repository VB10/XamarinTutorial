using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace XamarinDers1
{
	public class Student
	{
		public string name
		{
			get;
			set;
		}
		public int number
		{
			get;
			set;
		}

	}

	public partial class Ders2Page : ContentPage
	{
		public Ders2Page()
		{
			InitializeComponent();

			var list = new List<Student>
			{
				new Student{name="veli",number=12},
				new Student{name="veli2",number=122}
			};


			veli.ItemsSource = list;
		}

	
	}
}
