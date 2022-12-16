using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PTM.Domain.Queries.Tasks;
using PTM.Domain.Tasks;
using System.Net;
using System.Security.AccessControl;

namespace Personal_Task_Manager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    { 
        private readonly ILogger<TaskController> _logger;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetTasks")]
        [ProducesResponseType(typeof(List<Work>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]

        public async Task<IActionResult> GetAll()
        {
            var query = new TaskQuery();
            var tasks = query.GetTasks();
            if (tasks.Count() == 0)
                return NoContent();
            return Ok(tasks);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> AddTask([FromBody] Work work)
        {
            var query = new TaskQuery();
            if (work == null)
                return BadRequest();
            query.AddTask(new Work(work.Title,work.Description,work.StartDateTime,work.FinishedDateTime,work.Status));
            return Ok(work);

        }

    }
}