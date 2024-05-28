using Tasker.MVVM.Views;
using TASKER.MVVM.Views;

namespace Tasker;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainView());
	}
}
