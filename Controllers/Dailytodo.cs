using Microsoft.AspNetCore.Mvc;
using Webapiproject.Models;

namespace Webapiproject.Controllers
{
    //[Route("api/[controller]")]
    [ApiController]
    public class Dailytodo : ControllerBase
    {
        [HttpGet]
        [Route("All",Name ="GetAllTasks")]
        public IEnumerable<Tasks> gettask()
        {
            return TasksRepository.Taskss;
        }
        [HttpGet]
        [Route("{id}", Name = "GetTasksById")]
        public Tasks gettaskbyId(int id)
        {
            return TasksRepository.Taskss.Where(n => n.Id==id).FirstOrDefault();
        }
        [HttpGet("{name}",Name ="GetTaskByName")]

        public Tasks gettaskbyName(string name)
        {
            return TasksRepository.Taskss.Where(n => n.Taskname == name).FirstOrDefault();
        }
        [HttpPost]
        [Route("CreateTask")]
        public ActionResult<Tasks> CreateTask([FromBody] Tasks task)
        {
            if (task == null)
            {
                return BadRequest("Task data is null");
            }

            
            int newTaskId = TasksRepository.Taskss.Max(t => t.Id) + 1;
            task.Id = newTaskId;

            
            TasksRepository.Taskss.Add(task);

            
            return CreatedAtAction(nameof(gettaskbyId), new { id = newTaskId }, task);
        }
        [HttpDelete("{id}", Name="DeleteStudentsById")]
        public bool Deletetasks(int id)
        {
            var s=TasksRepository.Taskss.Where(n => n.Id == id).FirstOrDefault();
            TasksRepository.Taskss.Remove(s);
            return true;

        }








    }
}
