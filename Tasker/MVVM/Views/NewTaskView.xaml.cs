using Tasker.MVVM.Models;
using Tasker.MVVM.ViewModels;

namespace Tasker.MVVM.Views;

public partial class NewTaskView : ContentPage
{
	public NewTaskView()
	{
		InitializeComponent();
	}

	private async void AddTaskClicked(object sender, EventArgs e)
	{
		NewTaskViewModel? vm = BindingContext as NewTaskViewModel;

		Category? selectedCategory = vm.Categories.Where(c => c.IsSelected == true).FirstOrDefault();

		if (selectedCategory != null)
		{
			MyTask? task = new MyTask
			{
				TaskName = vm.Task,
				CategoryId = selectedCategory.Id
			};

			vm.Tasks.Add(task);

			await Navigation.PopAsync();
		}
		else
		{
			await DisplayAlert("Error", "Please select a category", "OK");
		}
	}

	private async void AddCategoryClicked(object sender, EventArgs e)
	{
		NewTaskViewModel? vm = BindingContext as NewTaskViewModel;

		string category = await DisplayPromptAsync("New Category", "Enter the name of the category", "OK", "Cancel", "Category name", 16, Keyboard.Text);

		Random? r = new Random();

		if (!string.IsNullOrEmpty(category))
		{
			vm.Categories.Add(new Category
			{
				Id = vm.Categories.Max(c => c.Id) + 1,
				Color = Color.FromRgb(r.Next(0, 255), r.Next(0, 255), r.Next(0, 255)).ToHex(),
				CategoryName = category
			});
		}
	}
}