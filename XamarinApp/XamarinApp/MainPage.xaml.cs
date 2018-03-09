using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinApp
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            var list = new List<Student>
		    {
		        new Student("Jotaro", 3),
		        new Student("Giorno", 5),
		        new Student("Kakyoin", 3),
		        new Student("Josuke", 4)
		    };

		    ListView.ItemsSource = list;

		    ListView.BindingContext = list;

		}
	}
}
