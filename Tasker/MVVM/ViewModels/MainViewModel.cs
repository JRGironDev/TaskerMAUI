using System.Collections.ObjectModel;
using Tasker.MVVM.Models;

namespace Tasker.MVVM.ViewModels;

public class MainViewModel
{
    public ObservableCollection<Category> Categories { get; set; }

    public MainViewModel()
    {
        FillData();
    }

    private void FillData()
    {
        Categories = new ObservableCollection<Category>
        {
            new Category
            {
                Id = 1,
                CategoryName = ".NET MAUI Course",
                Color = "#FF0000"
            },
            new Category
            {
                Id = 2,
                CategoryName = "Tutorials",
                Color = "#00FF00"
            },
            new Category
            {
                Id = 3,
                CategoryName = "Personal",
                Color = "#0000FF"
            }
        };
    }
}
