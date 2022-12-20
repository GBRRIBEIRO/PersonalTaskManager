using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PTM.Domain.DTOs.Tasks;
using PTM.Domain.Tasks;
using PTM.Infra.Repositories;
using System.Net;
using System.Security.AccessControl;

namespace Personal_Task_Manager.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : ControllerBase
    { 
        private readonly ILogger<TaskController> _logger;
        private readonly Repository<Work> _repository;

        public TaskController(ILogger<TaskController> logger)
        {
            _logger = logger;
            _repository = new Repository<Work>();
        }

        [HttpGet(Name = "GetTasks")]
        [ProducesResponseType(typeof(List<Work>), (int)HttpStatusCode.OK)]
        [ProducesResponseType((int)HttpStatusCode.NoContent)]

        public async Task<IActionResult> GetAll()
        {
            var tasks = _repository.GetAll();
            if (tasks.Count() == 0)
                return NoContent();
            return Ok(tasks);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.Created)]
        [ProducesResponseType((int)HttpStatusCode.BadRequest)]
        public async Task<IActionResult> AddTask([FromBody] TaskDTO work)
        {
            if (work == null)
                return BadRequest();

            
            _repository.Add(new Work(work));
            _repository.Save();
            return CreatedAtAction(nameof(GetAll),true,work);


        }

    }
}