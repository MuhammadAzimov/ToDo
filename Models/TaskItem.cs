namespace ToDo.Models;

public class TaskItem
{
    public int Id { get; set; }
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public bool IsCompleted { get; set; } = false;
    public DateTime? DueDate { get; set; }
    public int? CatergoryId { get; set; }
    public Category? Category { get; set; }
    public Priority Priority { get; set; } = Priority.Medium;
    public int CategoryId { get; set; }
    public Category Catergory { get; set; }

}