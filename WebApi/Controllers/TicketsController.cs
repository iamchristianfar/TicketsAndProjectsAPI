using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiApplication.Filters;
using WebApiApplication.Models;

namespace WebApiApplication.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            // Authentication and Authorization

            // Generic Validation

            // Retrive the Input Data

            // Data Validation

            // Application Logic / Data
            
            // Format Output Data

            // Exception Handling 
            return Ok("Reading all the tickets");
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok($"Reading ticket #{id}.");
        }

        [HttpPost]

        public IActionResult PostV1([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpPost]
        [Route ("/api/v2/tickets")]
        [Ticket_ValidateDatesActionFilter]
        public IActionResult PostV2([FromBody] Ticket ticket)
        {
            return Ok(ticket);
        }

        [HttpPut]
        public IActionResult Put([FromBody] Ticket ticket)
        {
            return Ok(ticket);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok($"Deleting ticket #{id}.");

        }
    }
}
