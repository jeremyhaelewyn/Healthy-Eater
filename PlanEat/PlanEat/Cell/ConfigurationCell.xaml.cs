using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace PlanEat
{
	public partial class ConfigurationCell : ViewCell
	{
		public ConfigurationCell()
		{
			InitializeComponent();
		}

		public static readonly BindableProperty NameProperty =
	BindableProperty.Create("Name", typeof(string), typeof(ViewCell), "");

		public string Name
		{
			get { return (string)GetValue(NameProperty); }
			set { SetValue(NameProperty, value); }
		}

		public static readonly BindableProperty DescriptionProperty =
	BindableProperty.Create("Description", typeof(string), typeof(ViewCell), "");

		public string Description
		{
			get { return (string)GetValue(DescriptionProperty); }
			set { SetValue(DescriptionProperty, value); }
		}


		public static readonly BindableProperty ImageFilenameProperty =
		  BindableProperty.Create("ImageFilename", typeof(string), typeof(ViewCell), "");

		public string ImageFilename
		{
			get { return (string)GetValue(ImageFilenameProperty); }
			set { SetValue(ImageFilenameProperty, value); }
		}
	}
}
