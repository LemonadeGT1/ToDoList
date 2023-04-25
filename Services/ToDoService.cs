
namespace ToDoList.Services;

public class ToDoService
{
  private readonly ToDoRepository _repo;

  public ToDoService(ToDoRepository repo)
  {
    _repo = repo;
  }

  internal List<ToDo> Get()
  {
    List<ToDo> toDos = _repo.Get();
    return toDos;
  }

  internal ToDo GetOne(int toDoId)
  {
    ToDo todo = _repo.GetOne(toDoId);
    if (todo == null) throw new Exception($"No ToDo found with id: {toDoId}");
    return todo;
  }

  internal ToDo Create(ToDo toDoData)
  {
    return _repo.Create(toDoData);
  }

  internal string Remove(int toDoId)
  {
    ToDo toDo = this.GetOne(toDoId);
    _repo.Remove(toDoId);
    return $"{toDo.Title} was removed";
  }

  internal ToDo Update(ToDo toDoData)
  {
    return _repo.Update(toDoData);
  }
}
