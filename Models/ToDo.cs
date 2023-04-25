
namespace ToDoList.Models;

public class ToDo
{
  public ToDo(string title, string body, bool isComplete, int id)
  {
    Title = title;
    Body = body;
    IsComplete = isComplete;
    Id = id;
  }

  public int Id { get; set; }
  public string Title { get; set; }
  public string Body { get; set; }
  public bool IsComplete { get; set; }
}
