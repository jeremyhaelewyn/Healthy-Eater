using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace PlanEat
{
	public class MovableCell : ViewCell
	{

		public static BindableProperty CustomReorderCommaondProperty = BindableProperty.Create("CustomReorderCommaond", typeof(Command<ReorderCommandParameters>), typeof(MovableCell));
		public static BindableProperty BeginReorderCommandProperty = BindableProperty.Create("BeginReorderCommand", typeof(Command<ReorderCommandParameters>), typeof(MovableCell));
		public static BindableProperty EndReorderCommandProperty = BindableProperty.Create("EndReorderCommand", typeof(ICommand), typeof(MovableCell));

		/// <summary>
		/// Command for custom reordering.
		/// Called when touch point within a new row.
		/// </summary>
		/// <remarks>
		/// If not null, all internal reordering logics will be ignored.
		/// </remarks>
		public Command<ReorderCommandParameters> CustomReorderCommand
		{
			get { return (Command<ReorderCommandParameters>)GetValue(CustomReorderCommaondProperty); }
			set { SetValue(CustomReorderCommaondProperty, value); }
		}

		public Command<ReorderCommandParameters> BeginReorderCommand
		{
			get { return (Command<ReorderCommandParameters>)GetValue(BeginReorderCommandProperty); }
			set { SetValue(BeginReorderCommandProperty, value); }
		}

		public ICommand EndReorderCommand
		{
			get { return (ICommand)GetValue(EndReorderCommandProperty); }
			set { SetValue(EndReorderCommandProperty, value); }
		}


	}
}
