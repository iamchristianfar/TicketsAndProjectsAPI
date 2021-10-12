using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiApplication.Models;

namespace WebApiApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Reading all the project.");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading project #{id}.");

        }

        /// <summary>
        ///   api/projects/{pid}/tickets?tid={tid}
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        /// 
        /*  
           [HttpGet]
           [Route("/api/projects/{pid}/tickets")]
           public IActionResult GetProjectTicket([FromQuery] Ticket ticket)
           {
               if (ticket == null) return BadRequest("Parameters are not provided properly");

               if (ticket.TicketId== 0)
                   return Ok($"Reading all the tickest belong to project #{ticket.ProjectId}");
               else
                   return Ok($"Reading project #{ticket.ProjectId}, ticket #{ticket.TicketId}, title: {ticket.Title}, description: {ticket.Description}");
           }
        */


        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket(int pId, [FromQuery] int tId)
        {

            if (tId == 0)
                return Ok($"Reading all the tickest belong to project #{pId}");
            else
                return Ok($"Reading project #{pId}, ticket #{tId}");
        }

        [HttpPost]
        public IActionResult Post(int id)
        {
            return Ok($"Reading project ${id}.");
        }

        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Updating a project");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting project #{id}.");

        }
    }
}
