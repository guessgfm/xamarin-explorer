using System;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace XamarinExplorer.Views
{
	public partial class TabsPage
	{
		public TabsPage()
		{
			InitializeComponent();

			var aboutCommand = this.GetNavigationCommand(() => new AboutPage { Title = "Go back" });
			AboutToolbarItem.Command = aboutCommand;

			//On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
			//On<Xamarin.Forms.PlatformConfiguration.iOS>().set(true);

			MenuScreen.Menu.Add(this.GetMenuItem("Controls", new ControlsPage()));
			MenuScreen.Menu.Add(this.GetMenuItem("Lists", new ItemsPage()));
		}
	}
}