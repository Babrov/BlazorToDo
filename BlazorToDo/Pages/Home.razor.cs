using BlazorToDo.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace BlazorToDo.Pages;

public partial class Home
{
    private readonly List<ToDoItem> items =
        new()
        {
            new ToDoItem { IsDone = true, Title = "Add modal", Description = "Modal form" },
            new ToDoItem { IsDone = false, Title = "Add validation", Description = "Just for testing validation" }
        };


    private EditContext? editContext;

    private bool isModalOpen;

    private ValidationMessageStore? messageStore;
    [SupplyParameterFromForm] private ToDoItem TodoItemModel { get; }

    private List<ToDoItem> completedItems => items.Where(item => item.IsDone).ToList();

    private void HandleValidSubmit()
    {
        Console.WriteLine("submitted");
        Console.WriteLine(TodoItemModel.Description);
    }

    private void OpenModal()
    {
        isModalOpen = true;
    }

    private void ModalClose()
    {
        isModalOpen = false;
    }

    private void ToDoChecked(IToDoItem item)
    {
        item.IsDone = !item.IsDone;
    }
}