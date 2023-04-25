

namespace ToDoList.Controllers;

[ApiController]
[Route("api/todos")]
public class ToDoController : ControllerBase
{
  private readonly ToDoService _toDoService;
  public ToDoController(ToDoService toDoService)
  {
    _toDoService = toDoService;
  }

  [HttpGet]
  public ActionResult<List<ToDo>> Get()
  {
    try
    {
      List<ToDo> toDos = _toDoService.Get();
      return Ok(toDos);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpGet("{toDoId}")]
  public ActionResult<ToDo> GetOne(int toDoId)
  {
    try
    {
      ToDo toDo = _toDoService.GetOne(toDoId);
      return Ok(toDo);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<ToDo> Create([FromBody] ToDo toDoData)
  {
    try
    {
      ToDo toDo = _toDoService.Create(toDoData);
      return Ok(toDo);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
      throw;
    }
  }

  [HttpDelete("{toDoId}")]
  public ActionResult<string> Remove(int toDoId)
  {
    try
    {
      string message = _toDoService.Remove(toDoId);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
      throw;
    }
  }

  [HttpPut]
  public ActionResult<ToDo> Update([FromBody] ToDo toDoData)
  {
    try
    {
      ToDo toDo = _toDoService.Update(toDoData);
      return Ok(toDo);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}
