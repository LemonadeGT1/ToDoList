
namespace ToDoList.Repositories;

public class ToDoRepository
{
  private readonly FakeDB _db;

  public ToDoRepository(FakeDB db)
  {
    _db = db;
  }

  internal List<ToDo> Get()
  {
    return _db.ToDos;
  }

  internal ToDo GetOne(int toDoId)
  {
    ToDo toDo = _db.ToDos.Find(t => t.Id == toDoId);
    return toDo;
  }

  internal ToDo Create(ToDo toDoData)
  {
    int toDoId = _db.ToDos[_db.ToDos.Count - 1].Id + 1;
    ToDo newToDo = new ToDo(toDoData.Title, toDoData.Body, toDoData.IsComplete, toDoData.Id);
    _db.ToDos.Add(newToDo);
    return newToDo;
  }

  internal void Remove(int toDoId)
  {
    ToDo toDo = this.GetOne(toDoId);
    _db.ToDos.Remove(toDo);
  }

  internal ToDo Update(ToDo toDoData)
  {
    ToDo oldToDo = this.GetOne(toDoData.Id);
    ToDo newToDo = toDoData;
    newToDo.Id = toDoData.Id;
    newToDo.Title = toDoData.Title == null ? oldToDo.Title : toDoData.Title;
    newToDo.Body = toDoData.Body == null ? oldToDo.Body : toDoData.Body;
    newToDo.IsComplete = toDoData.IsComplete;

    _db.ToDos.Remove(oldToDo);
    _db.ToDos.Add(newToDo);
    return newToDo;
  }
}
