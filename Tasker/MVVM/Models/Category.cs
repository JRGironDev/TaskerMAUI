namespace Tasker.MVVM.Models;

public class Category
{
    public int Id { get; set; }

    public required string CategoryName { get; set; }

    public required string Color { get; set; }

    public int PendingTasks { get; set; }   

    public float Percentage { get; set; }
}
