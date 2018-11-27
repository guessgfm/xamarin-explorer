using XamarinExplorer.Models;

namespace XamarinExplorer.Views
{
	public partial class ItemDetailPage
	{
		public ItemDetailPage(Product model)
		{
			InitializeComponent();

			BindingContext = new {
				Title = model?.Name,
				Item = model 
			};
		}

		public ItemDetailPage()
		{
			InitializeComponent();


			BindingContext = new
			{
				Title = "Item 1",
				Item = new Item {
					Text = "This is an item description."
				} 
			};
		}
	}
}