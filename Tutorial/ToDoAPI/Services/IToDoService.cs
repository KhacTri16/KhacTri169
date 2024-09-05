namespace Services;
    using ToDoAPI.Models;
using Microsoft.AspNetCore.Mvc;

interface IToDoService
{
    Task<ActionResult<IEnumerable<TodoItemDTO>>> GetTodoItems();
    Task<ActionResult<TodoItemDTO>> GetTodoItem(long id);
    Task<IActionResult> PutTodoItem(long id, TodoItemDTO todoDTO);
    Task<ActionResult<TodoItemDTO>> PostTodoItem(TodoItemDTO todoDTO);
    Task<IActionResult> DeleteTodoItem(long id);
    //neu them static la goi co dinh
    public  TodoItemDTO ItemToDTO(TodoItem todoItem);
    public bool TodoItemExists(long id);

}

