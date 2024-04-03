using System.ComponentModel.DataAnnotations;

namespace BlazorToDo.Shared;

public interface IToDoItem
{
    [Required(ErrorMessage = "Title is required")]
    [StringLength(20, ErrorMessage = "Title must be at most 100 characters")]
    string Title { get; set; }

    [StringLength(50, ErrorMessage = "Description must be at most 500 characters")]
    public string Description { get; set; }

    bool IsDone { get; set; }
}

public class ToDoItem : IToDoItem
{
    public bool IsDone { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
}