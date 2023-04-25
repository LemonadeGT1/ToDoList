
namespace ToDoList.Repositories;

public class FakeDB
{
  public List<ToDo> ToDos;

  public FakeDB()
  {
    ToDos = new List<ToDo>();
    ToDos.Add(new ToDo("Here is the Title.", "Here is the Body.", false, 1));
    ToDos.Add(new ToDo("Wash the Dishes.", "Use a soapy rag.", false, 2));
    ToDos.Add(new ToDo("Clean the pots and pans.", "Look for them on the stove.", false, 3));
  }
}
