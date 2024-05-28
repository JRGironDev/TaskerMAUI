using Tasker.MVVM.ViewModels;

namespace TASKER.MVVM.Views;

public partial class MainView : ContentPage
{
	private MainViewModel mainViewModel = new MainViewModel();

	public MainView()
	{
		InitializeComponent();

		BindingContext = mainViewModel;
	}

	private void checkBox_CheckedChanged(object sender, CheckedChangedEventArgs e)
	{
		mainViewModel.UpdateData();
	}
}