using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Paperboy.Pages
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage()
		{
			InitializeComponent();
		}

		protected override void OnAppearing()
		{
			InitializeSettings();
			base.OnAppearing();
		}

		private void InitializeSettings()
		{
			//displayNameEntry.Text = "Jawand";
			//bioEditor.Text = "Jawand is a Full Stack .NET developer.";
			//articleCountSlider.Value = 40;
			//categoryPicker.SelectedIndex = 1;
		}
	}
}