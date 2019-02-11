using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinExplorer
{
	public static class Utils
	{
		public static MenuItem GetMenuItem(this Page parent, string title, Page page)
		{
			return new MenuItem { Text = title, Command = parent.GetNavigationCommand(() => page) };
		}

		public static ICommand GetNavigationCommand(this Page parent, Func<Page> pageFunc)
		{
			return new Command(() =>
			{
				var page = pageFunc();

				parent.Navigation.PushAsync(page);
			});
		}
	}
}
