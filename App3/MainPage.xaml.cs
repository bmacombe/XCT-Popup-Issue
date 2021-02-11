using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;

namespace App3
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

		private void Button_OnClicked(object sender, EventArgs e)
		{
			App.Current.MainPage.Navigation.ShowPopup(new TestPopup());
		}
	}
}
