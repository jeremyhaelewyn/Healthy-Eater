using System;
using System.Collections.Generic;
using Rg.Plugins.Popup.Extensions;
using Rg.Plugins.Popup.Pages;
using Xamarin.Forms;

namespace PlanEat
{
	public partial class ConfigurationView : ContentPage
	{
		public ConfigurationView()
		{
			InitializeComponent();

			ListItemsConfiguration items = new ListItemsConfiguration();
			//List<ConfigurationItem> items = new List<ConfigurationItem>();
			items.Add(new ConfigurationItem() { Name = "Petit Dej", Description = "Du café mgl", ImageFilename = "alarm-clock.png" });
			items.Add(new ConfigurationItem() { Name = "Dej", Description = "Du riz", ImageFilename = "alarm-clock.png" });
			items.Add(new ConfigurationItem() { Name = "Gouter", Description = "Du pain", ImageFilename = "alarm-clock.png" });

			listView.ItemsSource = items;

			AddButton.Clicked += (sender, e) => Navigation.PushPopupAsync(new EditConfigurationItemView());
		}
	}
}
