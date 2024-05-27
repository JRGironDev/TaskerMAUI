namespace Tasker.MVVM.Models;

public class MyTask
{
    public required string TaskName { get; set; }

    public bool Completed { get; set; }

    public int CategoryId { get; set; }

    public string TaskColor { get; set; }
}
