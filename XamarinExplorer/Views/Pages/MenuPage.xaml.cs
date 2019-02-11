using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinExplorer.Views
{
	public partial class MenuPage : ContentPage
	{
		public MenuPage()
		{
			InitializeComponent();

			AddCommand = new Command(() => {

				var id = $"test{Menu.Count - 1}";

				Menu.Add(
					this.GetMenuItem(id, new ItemDetailPage(new Models.Item { 
						Description = "NFC test" + $"id:04CA953AA54880{Environment.NewLine}android.nfc.tech.NfcA{Environment.NewLine}android.nfc.tech.MifareUltralight{Environment.NewLine}"
					, Text = id }))
				);
			});
			BindingContext = this;
		}

		public ICollection<MenuItem> Menu { get; } = new ObservableCollection<MenuItem>();
		public ICommand AddCommand { get; }
	}
}
