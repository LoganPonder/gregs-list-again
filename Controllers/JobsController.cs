using System;
using System.Collections.Generic;
using gregs_list_again.DB;
using gregs_list_again.Models;
using gregs_list_again.Services;
using Microsoft.AspNetCore.Mvc;

namespace gregs_list_again.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : ControllerBase
    {
        private readonly JobsService _service;

        public JobsController(JobsService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Job>> GetAllJobs()
        {
            try
            {
                return Ok(FakeDB.Jobs);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpGet("{id}")]
        public ActionResult<Job> GetJobById(string id)
        {
            try
            {
                Job found = _service.GetJobById(id);
                return Ok(found);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPost]
        public ActionResult<Job> CreateJob([FromBody] Job newJob)
        {
            try
            {
                Job job = _service.CreateJob(newJob);
                return Ok(job);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpPut("{id}")]
        public ActionResult<Job> EditJob([FromBody] Job editJob, string id)
        {
            try
            {
                editJob.Id = id;
                Job job = _service.EditJob(editJob);
                return Ok(job);
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        [HttpDelete("{id}")]
        public ActionResult<Job> DeleteJob(string id)
        {
            try
            {
                _service.DeleteJob(id);
                return Ok("Successfully Deleted");
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}