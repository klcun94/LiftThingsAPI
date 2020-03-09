using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LiftThingsAPI.ApiModels;
using LiftThingsAPI.Core.Models;
using LiftThingsAPI.Core.Services;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LiftThingsAPI.Controllers
{
    [Route("api/[controller]")]
    public class RoutineController : Controller
    {
        private readonly IRoutineService _routineService;

        public RoutineController(IRoutineService routineService)
        {
            _routineService = routineService;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Ok(_routineService.GetAll().ToApiModels());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetRoutine", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //GET api/routine/id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            try
            {
                return Ok(_routineService.Get(id).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("GetRoutine", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //POST api/routine
        [HttpPost]
        public IActionResult Post([FromBody] Routine routine)
        {
            try
            {
                return Ok(_routineService.Add(routine).ToApiModel());
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PostRoutine", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //PUT api/routine/id
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Routine routine)
        {
            try
            {
                var b = _routineService.Update(routine).ToApiModel();

                return Ok(b);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("PutRoutine", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }

        //DELETE api/routine/id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _routineService.Remove(id);

                return Ok();
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("RemoveRoutine", ex.StackTrace);
                return BadRequest(ModelState);
            }
        }
    }
}
